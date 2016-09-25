using Depcom.TaberIsla.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Depcom.TaberIsla.Repository.Base
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        /// <summary>
        /// Returns a collection of <typeparamref name="TEntity"/>. Parameters are optional.
        /// <example>
        /// <code>
        /// <para>//returns the all records:</para>
        /// <para> ... = ...Get(); </para>
        /// <para>//returns records whose SomeProperty property is equals to "somevalue":</para>
        /// <para>... = ...Get(o=> o.SomeProperty == "someValue"); </para>
        /// <para>//returns records ordered by SomeProperty property:</para>
        /// <para>... = ...Get(null, o=> o.OrderBy(s=> s.SomeProperty)); </para>
        /// <para>//returns records whose SomeProperty property is equals to "somevalue" and  ordered by SomeProperty property:</para>
        /// <para>... = ...Get(f=> f.SomeProperty == "someValue", o=> o.OrderBy(s=> s.SomeProperty)); </para>
        /// </code>
        /// </example>
        /// </summary>
        /// <typeparam name="T">The element type of the collection.</typeparam>
        /// <param name="filter">Optional. This parameter specifies the filter for the query, for example:
        /// <para>
        /// <code>o=> o.SomeProperty.Equals("someValue")</code>
        /// </para>
        /// </param>
        /// <param name="orderBy">Optional. This parameter specifies the Order By for the query, for example:
        /// <para>
        /// <code>o=> o.OrderBy(s=> s.SomeProperty)</code>
        /// </para>
        /// </param>
        /// <returns>Returns a collection of <typeparamref name="TEntity"/>. Parameters are optional.</returns>
        IList<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, params Expression<Func<TEntity, object>>[] includes);

        TEntity GetByKey(Expression<Func<TEntity, bool>> keyFilter, params Expression<Func<TEntity, object>>[] includes);
    }
}
