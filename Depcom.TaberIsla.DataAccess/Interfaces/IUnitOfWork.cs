using Depcom.TaberIsla.Repository;
using Depcom.TaberIsla.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depcom.TaberIsla.DataAccess.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        string UserName { get; set; }
        void SaveChanges();
        void SaveChanges(string currentUserName);

        IResponsablesRepository ResponsablesRepository { get; }
        INaufragosRepository NaufragosRepository { get; }
    }
}
