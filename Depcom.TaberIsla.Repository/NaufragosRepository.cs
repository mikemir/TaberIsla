using Depcom.TaberIsla.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Depcom.TaberIsla.Domain;
using System.Linq.Expressions;
using Depcom.TaberIsla.Repository.Base;
using System.Data.Entity;

namespace Depcom.TaberIsla.Repository
{
    public class NaufragosRepository : Repository<Naufrago>, INaufragosRepository
    {
        public NaufragosRepository(DbContext dbContext) : base(dbContext)
        {

        }
    }
}
