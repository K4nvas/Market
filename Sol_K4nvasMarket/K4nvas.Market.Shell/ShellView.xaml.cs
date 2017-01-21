using K4nvas.Market.Module.Seguridad.ViewModel.Interface;
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

namespace K4nvas.Market.Shell
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
            set
            {

                this.DataContext = value;
            }
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            ////this.Close();
            this.Hide();
            //var user = (Komatsu.Core.Seguridad.ServicioUsuario.Usuario)System.Windows.Application.Current.Resources["UsuarioLogeado"];

            //MyHub.collectionGroup = new List<String>();

            MarketBootstrapper MarketBootstrapper = new MarketBootstrapper();
            MarketBootstrapper.Run();
            //MyNotifyIcon.Dispose();

        }
    }
}
