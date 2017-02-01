using Fluent;
using K4nvas.Market.Module.Seguridad.View.Interface;
using K4nvas.Market.Module.Seguridad.ViewModel.Interface;
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
