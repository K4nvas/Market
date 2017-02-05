using K4nvas.Market.Repository.Contract.Test;
using K4nvas.Market.Repository.Test;
using Microsoft.Practices.Unity;

namespace K4nvas.Market.DependencyResolver
{
    public class RepositoryModule
    {
        public static void RegisterType(IUnityContainer oIUnityContainer)
        {
            oIUnityContainer.RegisterType<ITestRepository, TestRepository>();
        }
    }
}
