using K4nvas.Market.Module.Seguridad.View.Interface;
using System.ComponentModel.Composition;
using System.Windows.Controls;

namespace K4nvas.Market.Module.Seguridad.View
{
    [Export(typeof(IHomeView))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class HomeView : UserControl, IHomeView
    {
        public HomeView()
        {
            InitializeComponent();
        }
    }
}
