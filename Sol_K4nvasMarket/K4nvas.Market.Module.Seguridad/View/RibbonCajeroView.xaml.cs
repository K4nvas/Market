using K4nvas.Market.Module.Seguridad.View.Interface;
using K4nvas.Market.Module.Seguridad.ViewModel.Interface;
using System.ComponentModel.Composition;

namespace K4nvas.Market.Module.Seguridad.View
{
    [Export(typeof(IRibbonCajeroView))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class RibbonCajeroView : IRibbonCajeroView
    {
        public RibbonCajeroView()
        {
            InitializeComponent();
        }

        [Import]
        IRibbonCajeroViewModel ViewModel
        {
            set { this.DataContext = value; }
        }
    }
}
