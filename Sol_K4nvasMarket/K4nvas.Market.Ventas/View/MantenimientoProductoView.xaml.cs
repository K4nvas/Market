using K4nvas.Market.Ventas.View.Interface;
using K4nvas.Market.Ventas.ViewModel.Interface;
using System.ComponentModel.Composition;

namespace K4nvas.Market.Ventas.View
{
    [Export(typeof(IMantenimientoProductoView))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class MantenimientoProductoView 
    {
        public MantenimientoProductoView()
        {
            InitializeComponent();
        }

        [Import]
        IMantenimientoProductoViewModel ViewModel
        {
            get { return DataContext as IMantenimientoProductoViewModel; }
            set { this.DataContext = value; }
        }

    }
}
