using Depcom.TaberIsla.BusinessLogic.Interfaces;
using Depcom.TaberIsla.DataAccess;
using Depcom.TaberIsla.DataAccess.Interfaces;
using Depcom.TaberIsla.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depcom.TaberIsla.BusinessLogic
{
    public class ResponsablesBL : IResponsablesBL
    {
        private IResponsablesDAO _responsablesDao = null;
        public ResponsablesBL(IResponsablesDAO responsablesDao)
        {
            if (responsablesDao == null) throw new ArgumentNullException(nameof(responsablesDao));

            _responsablesDao = responsablesDao;
        }
        public void Delete(Responsable entity)
        {
            _responsablesDao.Delete(entity);
        }

        public IList<Responsable> GetAll()
        {
            return _responsablesDao.GetAll();
        }

        public Responsable GetByKey(int key)
        {
            return _responsablesDao.GetByKey(key);
        }

        public void Insert(Responsable entity)
        {
            _responsablesDao.Insert(entity);
        }

        public void Update(Responsable entity)
        {
            _responsablesDao.Update(entity);
        }
    }
}
