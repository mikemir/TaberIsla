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
using Depcom.TaberIsla.DataAccess.Base;

namespace Depcom.TaberIsla.DepencyResolver
{

    public class BootStrapper
    {

        public static IUnityContainer Run()
        {
            IUnityContainer container = new UnityContainer();

            container.RegisterType<IDbContextFactory, DbContextFactory>(new ContainerControlledLifetimeManager());
            container.RegisterType<IUnitOfWork, TaberIslaUnitOfWork>(new ContainerControlledLifetimeManager());

            container.RegisterType<IResponsablesRepository, ResposablesRepository>(new ContainerControlledLifetimeManager());
            container.RegisterType<INaufragosRepository, NaufragosRepository>(new ContainerControlledLifetimeManager());
            container.RegisterType<IBajasRepository, BajasRepository>(new ContainerControlledLifetimeManager());

            container.RegisterType<IResponsablesDAO, ResponsablesDAO>();
            container.RegisterType<INaufragosDAO, NaufragosDAO>();
            container.RegisterType<IBajasDAO, BajasDAO>();

            container.RegisterType<IResponsablesBL, ResponsablesBL>();
            container.RegisterType<INaufragosBL, NaufragosBL>();
            container.RegisterType<IBajasBL, BajasBL>();

            return container;
        }
    }
}
