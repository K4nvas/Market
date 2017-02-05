using K4nvas.Market.Ventas.View.Interface;
using K4nvas.Market.Ventas.ViewModel.Interface;
using System.ComponentModel.Composition;

namespace K4nvas.Market.Ventas.View.Flyout
{
    [Export(typeof(IFlyoutTestView))]
    public partial class FlyoutTestView : IFlyoutTestView
    {
        public FlyoutTestView()
        {
            InitializeComponent();
        }

        [Import]
        IFlyoutTestViewModel ViewModel
        {
            get { return DataContext as IFlyoutTestViewModel; }
            set { this.DataContext = value; }
        }
    }
}
