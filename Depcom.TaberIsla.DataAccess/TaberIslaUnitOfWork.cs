using Depcom.TaberIsla.DataAccess.Interfaces;
using Depcom.TaberIsla.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Depcom.TaberIsla.Repository.Interfaces;

namespace Depcom.TaberIsla.DataAccess
{
    public class TaberIslaUnitOfWork : IUnitOfWork
    {
        private DbContext _dbContext;
        private IDbContextFactory _contextFactory;
        private bool _disposed = false;

        public TaberIslaUnitOfWork(IDbContextFactory contextFactory)
        {
            if (contextFactory == null)
                throw new ArgumentNullException(nameof(contextFactory));

            _contextFactory = contextFactory;
            _dbContext = _contextFactory.GetDbContext();
        }

        public string UserName { get; set; }

        public IResponsablesRepository ResponsablesRepository
        {
            get
            {
                return new ResposablesRepository(_dbContext);
            }
        }

        public INaufragosRepository NaufragosRepository
        {
            get
            {
                return new NaufragosRepository(_dbContext);
            }
        }

        public virtual void SaveChanges()
        {
            SaveChanges(this.UserName ?? "NO_USER");
        }

        public void SaveChanges(string currentUserName)
        {
            _dbContext.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    this._dbContext.Dispose();
                }
            }
            this._disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
