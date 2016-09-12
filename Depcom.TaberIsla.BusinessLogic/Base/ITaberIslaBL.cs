using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depcom.TaberIsla.BusinessLogic.Base
{
    interface ITaberIslaBL<TEntity>
    {
        TEntity GetById(TEntity item);
        ICollection<TEntity> GetAll();
        void Insert(TEntity item);
        void Update(TEntity item);
        void Delete(TEntity item);
    }
}
