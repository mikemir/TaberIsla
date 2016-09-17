using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Depcom.TaberIsla.Repository;
using Depcom.TaberIsla.Repository.Interfaces;
using Depcom.TaberIsla.DataAccess.Interfaces;
using Depcom.TaberIsla.DataAccess;
using Depcom.TaberIsla.BusinessLogic.Interfaces;
using Depcom.TaberIsla.BusinessLogic;

namespace Depcom.TaberIsla.DepencyResolver
{

    public class BootStrapper
    {

        public static IUnityContainer Run()
        {
            IUnityContainer container = new UnityContainer();

            container.RegisterType<IDbContextFactory, DbContextFactory>();
            container.RegisterType<IUnitOfWork, TaberIslaUnitOfWork>();
            container.RegisterType<IResponsablesRepository, ResposablesRepository>();
            container.RegisterType<IResponsablesDAO, ResponsablesDAO>();
            container.RegisterType<IResponsablesBL, ResponsablesBL>();

            return container;
        }
    }
}
