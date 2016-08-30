using Depcom.TaberIsla.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Depcom.TaberIsla.Entity;
using Depcom.TaberIsla.DataAccess.Context;

namespace Depcom.TaberIsla.DataAccess
{
    public class ResponsablesDAO : IResponsablesDAO
    {
        public bool Delete(Responsable item)
        {
            throw new NotImplementedException();
        }

        public ICollection<Responsable> GetAll()
        {
            return new DbTaberIsla().Responsables.ToList();
        }

        public Responsable GetById(Responsable id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Responsable item)
        {
            var context = new DbTaberIsla();
            context.Responsables.Add(item);
            var result = context.SaveChanges();

            return result > 0;
        }

        public bool Update(Responsable item)
        {
            throw new NotImplementedException();
        }
    }
}
