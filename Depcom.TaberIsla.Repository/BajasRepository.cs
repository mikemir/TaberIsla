using Depcom.TaberIsla.Domain;
using Depcom.TaberIsla.Repository.Base;
using Depcom.TaberIsla.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Depcom.TaberIsla.Repository
{
    public class BajasRepository : Repository<Baja>, IBajasRepository
    {
        public BajasRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
