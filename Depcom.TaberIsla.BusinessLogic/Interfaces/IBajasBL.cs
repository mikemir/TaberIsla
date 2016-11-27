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
    public interface IBajasBL : ITaberIslaBL<Baja>
    {
        IList<Baja> Find(Expression<Func<Baja, bool>> filter = null);
    }
}
