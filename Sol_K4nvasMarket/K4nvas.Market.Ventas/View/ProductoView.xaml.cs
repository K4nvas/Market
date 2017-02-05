using K4nvas.Market.Ventas.View.Interface;
using K4nvas.Market.Ventas.ViewModel.Interface;
using System.ComponentModel.Composition;
using System.Windows.Controls;

namespace K4nvas.Market.Ventas.View
{
    [Export(typeof(IProductoView))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class ProductoView : UserControl, IProductoView
    {
        public ProductoView()
        {
            InitializeComponent();
        }

        [Import]
        IProductoViewModel ViewModel
        {
            get { return DataContext as IProductoViewModel; }
            set { this.DataContext = value; }
        }

    }
}
