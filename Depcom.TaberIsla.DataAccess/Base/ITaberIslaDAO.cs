using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depcom.TaberIsla.DataAccess.Base
{
    public interface ITaberIslaDAO<TEntity>
    {
        TEntity GetById(TEntity item);

        ICollection<TEntity> GetAll();

        TEntity Insert(TEntity item);

        bool Update(TEntity item);

        bool Delete(TEntity item);
    }
}
