using K4nvas.Market.Ventas.View.Interface;
using K4nvas.Market.Ventas.ViewModel.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
