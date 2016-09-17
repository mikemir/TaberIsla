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
    public class ResponsablesServices : IResponsablesServices
    {
        private IResponsablesBL _resposablesBl;

        public ResponsablesServices(IResponsablesBL responsablesBl)
        {
            if (responsablesBl == null)
                throw new ArgumentNullException(nameof(responsablesBl));

            _resposablesBl = responsablesBl;
        }
    }
}
