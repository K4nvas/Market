using K4nvas.Market.Module.Seguridad.ViewModel.Interface;
using K4nvas.Market.Shell.View.Interface;
using MahApps.Metro.Controls;
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

namespace K4nvas.Market.Shell.View
{
    [Export(typeof(IShellView))]
    public partial class ShellView : MetroWindow, IShellView
    {
        public ShellView()
        {
            InitializeComponent();
        }

        [Import]
        public ILoginViewModel ViewModel
        {
            get { return this.DataContext as ILoginViewModel; }
            set { this.DataContext = value; }
        }
    }
}
