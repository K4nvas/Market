using K4nvas.Market.Common.Infraestructure;
using K4nvas.Market.Module.Seguridad.View.Interface;
using Microsoft.Practices.Prism.MefExtensions.Modularity;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K4nvas.Market.Module.Seguridad
{
    [ModuleExport(typeof(SeguridadModule))]
    public class SeguridadModule : IModule
    {
        private IRegionViewRegistry regionViewRegistry;

        [ImportingConstructor]
        public SeguridadModule(IRegionViewRegistry regionViewRegistry)
        {
            this.regionViewRegistry = regionViewRegistry;
        }

        public void Initialize()
        {
            this.regionViewRegistry.RegisterViewWithRegion(RegionNames.LogonRegion, typeof(ILoginView));
        }


    }
}
