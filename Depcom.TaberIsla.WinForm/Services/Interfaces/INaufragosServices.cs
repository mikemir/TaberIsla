using Depcom.TaberIsla.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depcom.TaberIsla.WinForm.Services.Interfaces
{
    public interface INaufragosServices
    {
        IList<Naufrago> GetAll();
    }
}
