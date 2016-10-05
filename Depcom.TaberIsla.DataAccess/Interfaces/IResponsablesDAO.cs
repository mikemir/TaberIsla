using Depcom.TaberIsla.DataAccess.Base;
using Depcom.TaberIsla.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depcom.TaberIsla.DataAccess.Interfaces
{
    public interface IResponsablesDAO : ITaberIslaDAO<Responsable>
    {
        Responsable GetByDUI(string dui);
    }
}
