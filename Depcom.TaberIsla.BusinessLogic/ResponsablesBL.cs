using Depcom.TaberIsla.BusinessLogic.Base;
using Depcom.TaberIsla.BusinessLogic.Interfaces;
using Depcom.TaberIsla.DataAccess;
using Depcom.TaberIsla.DataAccess.Interfaces;
using Depcom.TaberIsla.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Depcom.TaberIsla.DataAccess.Base;

namespace Depcom.TaberIsla.BusinessLogic
{
    public class ResponsablesBL : IResponsablesBL
    {
        private IResponsablesBL _responsablesBl;

        public ResponsablesBL(IResponsablesBL responsablesBl)
        {
            if (responsablesBl == null)
                throw new ArgumentNullException(nameof(responsablesBl));

            _responsablesBl = responsablesBl;
        }

        public void Delete(Responsable entity)
        {
            _responsablesBl.Delete(entity);
        }

        public IList<Responsable> GetAll()
        {
            return _responsablesBl.GetAll();
        }

        public Responsable GetByKey(int key)
        {
            return _responsablesBl.GetByKey(key);
        }

        public void Insert(Responsable entity)
        {
            _responsablesBl.Insert(entity);
        }

        public void Update(Responsable entity)
        {
            _responsablesBl.Update(entity);
        }
    }
}
