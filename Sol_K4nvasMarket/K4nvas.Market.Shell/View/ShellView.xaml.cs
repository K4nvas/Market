using K4nvas.Market.Module.Seguridad.ViewModel.Interface;
using K4nvas.Market.Shell.View.Interface;
using MahApps.Metro.Controls;
using System.ComponentModel.Composition;

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
