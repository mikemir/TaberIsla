using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depcom.TaberIsla.WinForm.Utils.Interfaces
{
    public interface ICommunicable
    {
        void Received(object result);
    }

    public interface ICommunicable<TResult>
    {
        void Received(TResult result);
    }
}
