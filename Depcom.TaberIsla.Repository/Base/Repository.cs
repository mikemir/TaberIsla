using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Depcom.TaberIsla.Repository.Base
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected DbContext DbContext { get; set; }
        protected DbSet<T> DbSet { get; set; }

        public Repository(DbContext DbContext)
        {
            if (DbContext == null)
                throw new ArgumentNullException(nameof(DbContext));

            this.DbContext = DbContext;
            this.DbSet = DbContext.Set<T>();
        }

        #region CRUD
        public IList<T> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, params Expression<Func<T, object>>[] includes)
        {
            try
            {
                IQueryable<T> query = this.DbSet;
                if (filter != null) //where
                    query = query.Where(filter);

                //includes:
                if (includes != null)
                {
                    query = includes.Aggregate(query,
                              (current, include) => current.Include(include));
                }

                return (orderBy == null) ? query.ToList() : orderBy(query).ToList<T>();
            }
            catch
            {
                throw;
            }
        }

        public T GetByKey(Expression<Func<T, bool>> keyFilter, params Expression<Func<T, object>>[] includes)
        {
            try
            {
                if (keyFilter == null)
                    throw new ArgumentNullException(nameof(keyFilter));

                IQueryable<T> query = this.DbSet;
                query = query.Where(keyFilter);

                if (includes != null)
                {
                    query = includes.Aggregate(query,
                              (current, include) => current.Include(include));
                }

                return query.FirstOrDefault<T>();
            }
            catch
            {
                throw;
            }
        }

        public void Create(T entity)
        {
            try
            {
                DbEntityEntry dbEntityEntry = DbContext.Entry(entity);
                if (dbEntityEntry.State != EntityState.Detached)
                {
                    dbEntityEntry.State = EntityState.Added;
                }
                else
                {
                    DbSet.Add(entity);
                }
            }
            catch
            {
                throw;
            }
        }

        public void Update(T entity)
        {
            try
            {
                DbEntityEntry dbEntityEntry = DbContext.Entry(entity);
                if (dbEntityEntry.State == EntityState.Detached)
                {
                    DbSet.Attach(entity);
                }
                dbEntityEntry.State = EntityState.Modified;
            }
            catch
            {
                throw;
            }
        }

        public void Delete(T entity)
        {
            try
            {
                DbEntityEntry dbEntityEntry = DbContext.Entry(entity);
                if (dbEntityEntry.State != EntityState.Deleted)
                {
                    dbEntityEntry.State = EntityState.Deleted;
                }
                else
                {
                    DbSet.Attach(entity);
                    DbSet.Remove(entity);
                }
            }
            catch
            {
                throw;
            }
        }
        #endregion
    }
}
