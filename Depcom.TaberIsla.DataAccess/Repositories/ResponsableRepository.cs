using Depcom.TaberIsla.DataAccess.Base;
using Depcom.TaberIsla.DataAccess.Interfaces;
using Depcom.TaberIsla.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Depcom.TaberIsla.DataAccess.Repositories
{
    public class ResponsableRepository : Repository<Responsable>, IResponsablesRepository
    {
        public ResponsableRepository(DbContext DbContext) : base(DbContext)
        {
        }
    }
}
