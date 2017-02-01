using K4nvas.Market.Common.Helpers.ViewActivator;
using K4nvas.Market.Common.Infraestructure;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.ServiceLocation;

namespace K4nvas.Market.Common.Helpers
{
    public class ViewActivator<TView> : IViewActivator
        where TView : class
    {
        private static IViewActivator _Instance = null;
        private readonly IRegionManager regionManager;

        public static IViewActivator Instance
        {
            get { return _Instance ?? new ViewActivator<TView>(); }
        }

        public ViewActivator()
        {
            regionManager = ServiceLocator.Current.GetInstance<IRegionManager>();
        }

        public void Activate()
        {
            Deactivate();
            IRegion region = regionManager.Regions[RegionNames.WorkspaceRegion];
            string viewName = typeof(TView).Name;

            object configuracionView = region.GetView(viewName);
            if (configuracionView == null)
            {
                configuracionView = ServiceLocator.Current.GetInstance<TView>();
                region.Add(configuracionView, viewName);
            }
            region.Activate(configuracionView);
        }

        public void Deactivate()
        {
            IRegion region = regionManager.Regions[RegionNames.WorkspaceRegion];
            string viewName = typeof(TView).Name;

            object configuracionView = region.GetView(viewName);
            if (configuracionView != null)
            {
                region.Deactivate(configuracionView);
                region.Remove(configuracionView);
            }

        }
    }
}
