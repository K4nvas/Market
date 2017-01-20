﻿using K4nvas.Market.Service.Contract.Test;
using K4nvas.Market.Service.Test;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
