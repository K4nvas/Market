﻿using K4nvas.Market.Module.Seguridad;
using K4nvas.Market.Shell.View;
using K4nvas.Market.Shell.View.Interface;
using Microsoft.Practices.Prism.MefExtensions;
using Microsoft.Practices.Prism.Regions;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.ComponentModel.Composition;
using K4nvas.Market.Shell.Helper;
using K4nvas.Market.Ventas;

namespace K4nvas.Market.Shell
{
    public class MarketBootstrapper : MefBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return this.Container.GetExportedValue<IShellView>() as ShellView;
        }

        protected override void ConfigureAggregateCatalog()
        {
            base.ConfigureAggregateCatalog();
            this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(ShellView).Assembly));
            this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(SeguridadModule).Assembly));
            this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(VentasModule).Assembly));
        }

        protected override void InitializeShell()
        {
            App.Current.MainWindow = this.Shell as Window;
            App.Current.MainWindow.Show();
        }

        protected override RegionAdapterMappings ConfigureRegionAdapterMappings()
        {
            var mappings = base.ConfigureRegionAdapterMappings();
            mappings.RegisterMapping(typeof(Grid), Container.GetExportedValue<RibbonRegionAdapter>());
            return mappings;
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();
        }
    }
}
