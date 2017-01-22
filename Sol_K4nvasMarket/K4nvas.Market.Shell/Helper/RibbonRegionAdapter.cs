using System.Collections.Specialized;
using System.ComponentModel.Composition;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Practices.Prism.Regions;
using Fluent;

namespace K4nvas.Market.Shell.Helper
{
    /// <summary>
    /// Enables use of a Ribbon control as a Prism region.
    /// </summary>
    /// <remarks> See Developer's Guide to Microsoft Prism (Ver. 4), p. 189.</remarks>
    [Export]
    public class RibbonRegionAdapter : RegionAdapterBase<Grid>
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="behaviorFactory">Allows the registration of the default set of RegionBehaviors.</param>
        [ImportingConstructor]
        public RibbonRegionAdapter(IRegionBehaviorFactory behaviorFactory)
            : base(behaviorFactory)
        {
        }

        /// <summary>
        /// Adapts a WPF control to serve as a Prism IRegion. 
        /// </summary>
        /// <param name="region">The new region being used.</param>
        /// <param name="regionTarget">The WPF control to adapt.</param>
        protected override void Adapt(IRegion region, Grid regionTarget)
        {
            region.Views.CollectionChanged += (sender, e) =>
            {
                switch (e.Action)
                {
                    case NotifyCollectionChangedAction.Add:
                        foreach (FrameworkElement element in e.NewItems)
                        {
                            regionTarget.Children.Add(element);
                        }
                        break;

                    case NotifyCollectionChangedAction.Remove:
                        foreach (UIElement elementLoopVariable in e.OldItems)
                        {
                            var element = elementLoopVariable;
                            if (regionTarget.Children.Contains(element))
                            {
                                regionTarget.Children.Remove(element);
                            }
                        }
                        break;
                }
            };
        }

        protected override IRegion CreateRegion()
        {
            return new SingleActiveRegion();
        }
    }
}
