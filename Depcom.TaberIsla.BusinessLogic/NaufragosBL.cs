using Depcom.TaberIsla.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Depcom.TaberIsla.Domain;
using Depcom.TaberIsla.BusinessLogic.Base;
using Depcom.TaberIsla.DataAccess.Base;
using Depcom.TaberIsla.DataAccess.Interfaces;

namespace Depcom.TaberIsla.BusinessLogic
{
    public class NaufragosBL : INaufragosBL
    {
        private INaufragosDAO _naufragosDao;

        public NaufragosBL(INaufragosDAO naufragosDao)
        {
            if (naufragosDao == null)
                throw new ArgumentNullException(nameof(naufragosDao));

            _naufragosDao = naufragosDao;
        }

        public void Delete(Naufrago entity)
        {
            _naufragosDao.Delete(entity);
        }

        public IList<Naufrago> GetAll()
        {
            return _naufragosDao.GetAll();
        }

        public Naufrago GetByKey(int key)
        {
            return _naufragosDao.GetByKey(key);
        }

        public void Insert(Naufrago entity)
        {
            _naufragosDao.Insert(entity);
        }

        public void Update(Naufrago entity)
        {
            _naufragosDao.Update(entity);
        }
    }
}
