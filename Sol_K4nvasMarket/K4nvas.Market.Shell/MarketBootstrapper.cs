using Microsoft.Practices.Prism.MefExtensions;
using Microsoft.Practices.Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace K4nvas.Market.Shell
{
    public class MarketBootstrapper : MefBootstrapper
    {
        protected override void ConfigureAggregateCatalog()
        {
            base.ConfigureAggregateCatalog();
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();
        }

        protected override DependencyObject CreateShell()
        {
            return Container.GetExportedValue<IShellView>() as ShellView;
        }

        protected override RegionAdapterMappings ConfigureRegionAdapterMappings()
        {
            var mappings = base.ConfigureRegionAdapterMappings();
            //mappings.RegisterMapping(typeof(Grid), this.Container.GetExportedValue<RibbonRegionAdapter>());

            //mappings.RegisterMapping(typeof(DevExpress.Xpf.Grid.GridControl), this.Container.GetExportedValue<RibbonRegionAdapter>());
            //mappings.RegisterMapping(typeof(Microsoft.Practices.EnterpriseLibrary.Logging.LogWriter), this.Container.GetExportedValue<RibbonRegionAdapter>());
            return mappings;
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();
            //RegisterServiceTypes();
        }
    }
}
