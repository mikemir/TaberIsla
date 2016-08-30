using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depcom.TaberIsla.BusinessLogic.Base
{
    interface ITaberIslaBL<TEntity>
    {
        TEntity GetById(TEntity id);
        ICollection<TEntity> GetAll();
        bool Insert(TEntity item);
        bool Update(TEntity item);
        bool Delete(TEntity item);
    }
}
