using K4nvas.Market.Repository.Contract.Test;
using K4nvas.Market.Repository.Test;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
