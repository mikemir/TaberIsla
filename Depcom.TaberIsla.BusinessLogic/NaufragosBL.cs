using Depcom.TaberIsla.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Depcom.TaberIsla.Domain;
using Depcom.TaberIsla.BusinessLogic.Base;
using Depcom.TaberIsla.DataAccess.Base;

namespace Depcom.TaberIsla.BusinessLogic
{
    public class NaufragosBL : INaufragosBL
    {
        private INaufragosBL _naufragosBl;

        public NaufragosBL(INaufragosBL naufragosBl)
        {
            if (naufragosBl == null)
                throw new ArgumentNullException(nameof(naufragosBl));

            _naufragosBl = naufragosBl;
        }

        public void Delete(Naufrago entity)
        {
            _naufragosBl.Delete(entity);
        }

        public IList<Naufrago> GetAll()
        {
            return _naufragosBl.GetAll();
        }

        public Naufrago GetByKey(int key)
        {
            return _naufragosBl.GetByKey(key);
        }

        public void Insert(Naufrago entity)
        {
            _naufragosBl.Insert(entity);
        }

        public void Update(Naufrago entity)
        {
            _naufragosBl.Update(entity);
        }
    }
}
