using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depcom.TaberIsla.DataAccess.Interfaces
{
    public interface IDbContextFactory
    {
        DbContext GetDbContext();
    }
}
