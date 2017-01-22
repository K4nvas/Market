using System;
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
#if (DEBUG)
            RunInDebugMode();
#else
                            RunInReleaseMode();
#endif
            RunInReleaseMode();
        }

        private static void RunInDebugMode()
        {
            MarketBootstrapper bootstrapper = new MarketBootstrapper();
            bootstrapper.Run();
        }

        private static void RunInReleaseMode()
        {
            AppDomain.CurrentDomain.UnhandledException += AppDomainUnhandledException;
            try
            {
                MarketBootstrapper bootstrapper = new MarketBootstrapper();
                bootstrapper.Run();
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private static void AppDomainUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            HandleException(e.ExceptionObject as Exception);
        }

        private static void HandleException(Exception ex)
        {
            if (ex == null)
                return;

            //Logger.Write(ex);
            MessageBox.Show(ex.Message);
            Environment.Exit(1);
        }
    }
}
