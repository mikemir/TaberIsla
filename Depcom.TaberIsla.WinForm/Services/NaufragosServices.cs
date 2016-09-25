using Depcom.TaberIsla.WinForm.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Depcom.TaberIsla.Domain;
using Depcom.TaberIsla.BusinessLogic.Interfaces;

namespace Depcom.TaberIsla.WinForm.Services
{
    public class NaufragosServices : INaufragosServices
    {
        INaufragosBL _naufragosBl;
        public NaufragosServices(INaufragosBL naufragosBl)
        {
            if (naufragosBl == null)
                throw new ArgumentNullException(nameof(naufragosBl));

            _naufragosBl = naufragosBl;
        }
        public IList<Naufrago> GetAll()
        {
            return _naufragosBl.GetAll();
        }
    }
}
