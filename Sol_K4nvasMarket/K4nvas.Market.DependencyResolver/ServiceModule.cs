using K4nvas.Market.Service.Contract.Test;
using K4nvas.Market.Service.Contract.Ventas;
using K4nvas.Market.Service.Test;
using K4nvas.Market.Service.Ventas;
using Microsoft.Practices.Unity;

namespace K4nvas.Market.DependencyResolver
{
    public class ServiceModule
    {
        public static void RegisterType(IUnityContainer oIUnityContainer)
        {
            oIUnityContainer.RegisterType<ITestService, TestService>();
            oIUnityContainer.RegisterType<IVentasService, VentasService>();
        }
    }
}
