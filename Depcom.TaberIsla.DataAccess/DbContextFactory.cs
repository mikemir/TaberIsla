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
        private DbContext _context;

        public DbContext GetDbContext()
        {
            if (_context == null) InitializeContext();
            return _context;
        }

        private void InitializeContext()
        {
            _context = new DbTaberIslaContext();
            _context.Configuration.ProxyCreationEnabled = false;
            _context.Configuration.LazyLoadingEnabled = false;
            _context.Configuration.ValidateOnSaveEnabled = false;
        }
    }
}
