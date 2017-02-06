using K4nvas.Market.DependencyResolver;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Activation;
using System.Web;

namespace K4nvas.Market.ServiceHost.Factory
{
    public class UnityServiceHostFactory : ServiceHostFactory
    {
        private readonly IUnityContainer oIUnityContainer;

        public UnityServiceHostFactory()
        {
            oIUnityContainer = new UnityContainer();
            RegisterTypes(oIUnityContainer);
        }
        protected override System.ServiceModel.ServiceHost CreateServiceHost(Type serviceType, Uri[] baseAddresses)
        {
            return new UnityServiceHost(this.oIUnityContainer, serviceType, baseAddresses);
        }

        private void RegisterTypes(IUnityContainer oIUnityContainer)
        {
            ServiceModule.RegisterType(oIUnityContainer);
            DomainModule.RegisterType(oIUnityContainer);
            RepositoryModule.RegisterType(oIUnityContainer);
            
        }

    }
}