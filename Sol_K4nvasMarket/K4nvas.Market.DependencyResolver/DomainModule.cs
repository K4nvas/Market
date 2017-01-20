using K4nvas.Market.Domain.Contract.Test;
using K4nvas.Market.Domain.Test;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K4nvas.Market.DependencyResolver
{
    public class DomainModule
    {
        public static void RegisterType(IUnityContainer oIUnityContainer)
        {
            oIUnityContainer.RegisterType<ITestDomain, TestDomain>();
        }
    }
}
