using K4nvas.Market.Service.Contract.Test;
using K4nvas.Market.Service.Test;
using Microsoft.Practices.Unity;

namespace K4nvas.Market.DependencyResolver
{
    public class ServiceModule
    {
        public static void RegisterType(IUnityContainer oIUnityContainer)
        {
            oIUnityContainer.RegisterType<ITestService, TestService>();
        }
    }
}
