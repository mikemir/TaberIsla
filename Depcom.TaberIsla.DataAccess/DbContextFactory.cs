using Depcom.TaberIsla.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Depcom.TaberIsla.DataAccess.Context;

namespace Depcom.TaberIsla.DataAccess
{
    public class DbContextFactory : IDbContextFactory
    {
        public DbContext GetDbContext()
        {
            return new DbTaberIslaContext();
        }
    }
}
