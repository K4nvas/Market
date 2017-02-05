using K4nvas.Market.Ventas.View.Interface;
using K4nvas.Market.Ventas.ViewModel.Interface;
using System.ComponentModel.Composition;
using System.Windows.Controls;

namespace K4nvas.Market.Ventas.View
{
    [Export(typeof(ITestView))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class TestView : UserControl, ITestView
    {
        public TestView()
        {
            InitializeComponent();
        }

        [Import]
        ITestViewModel ViewModel
        {
            get { return DataContext as ITestViewModel; }
            set { this.DataContext = value; }
        }
    }
}
