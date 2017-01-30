﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace K4nvas.Market.Shell
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            RunInDebugMode();
            this.ShutdownMode = ShutdownMode.OnMainWindowClose;
            

        }



        private static void RunInDebugMode()
        {
            MarketBootstrapper bootstrapper = new MarketBootstrapper();
            bootstrapper.Run();
        }
    }
}
