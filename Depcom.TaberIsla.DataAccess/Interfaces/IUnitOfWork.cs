using Depcom.TaberIsla.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depcom.TaberIsla.DataAccess.Interfaces
{
    public interface IUnitOfWork
    {
        string UserName { get; set; }
        void SaveChanges();
        void SaveChanges(string currentUserName);

        IResponsablesRepository ResposablesRepository { get; }
    }
}
