using K4nvas.Market.Repository.Contract.Test;
using K4nvas.Market.Repository.Contract.Ventas;
using K4nvas.Market.Repository.Test;
using K4nvas.Market.Repository.Ventas;
using Microsoft.Practices.Unity;

namespace K4nvas.Market.DependencyResolver
{
    public class RepositoryModule
    {
        public static void RegisterType(IUnityContainer oIUnityContainer)
        {
            oIUnityContainer.RegisterType<ITestRepository, TestRepository>();
            oIUnityContainer.RegisterType<IVentasRepository, VentasRepository>();
        }
    }
}
