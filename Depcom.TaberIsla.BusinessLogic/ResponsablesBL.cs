using Depcom.TaberIsla.BusinessLogic.Interfaces;
using Depcom.TaberIsla.DataAccess;
using Depcom.TaberIsla.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depcom.TaberIsla.BusinessLogic
{
    public class ResponsablesBL : IResponsablesBL
    {
        public bool Delete(Responsable item)
        {
            return new ResponsablesDAO().Delete(item);
        }

        public ICollection<Responsable> GetAll()
        {
            return new ResponsablesDAO().GetAll();
        }

        public Responsable GetById(Responsable item)
        {
            return new ResponsablesDAO().GetById(item);
        }

        public Responsable Insert(Responsable item)
        {
            return new ResponsablesDAO().Insert(item);
        }

        public bool Update(Responsable item)
        {
            return new ResponsablesDAO().Update(item);
        }
    }
}
