using Depcom.TaberIsla.BusinessLogic.Base;
using Depcom.TaberIsla.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Depcom.TaberIsla.BusinessLogic.Interfaces
{
    public interface INaufragosBL : ITaberIslaBL<Naufrago>
    {
        int Count(Expression<Func<Naufrago, bool>> filter = null);
    }
}
