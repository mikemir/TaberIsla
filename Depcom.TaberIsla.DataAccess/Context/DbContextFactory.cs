using Depcom.TaberIsla.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Depcom.TaberIsla.DataAccess.Context
{
    public class DbContextFactory : IDbContextFactory
    {
        private DbTaberIslaContext _context;

        public DbSet GetAuditEntityDbSet()
        {
            throw new NotImplementedException();
        }

        public DbContext GetDbContext()
        {
            if (_context == null) InitializeContext();
            return _context;
        }

        private void InitializeContext()
        {
            this._context = new DbTaberIslaContext();
        }
    }
}
