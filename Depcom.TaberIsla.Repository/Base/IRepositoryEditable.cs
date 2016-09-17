using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depcom.TaberIsla.Repository.Base
{
    public interface IRepositoryEditable<TEntity> : IRepository<TEntity> where TEntity : class
    {
        void Create(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);
    }
}
