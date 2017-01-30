using K4nvas.Market.Module.Seguridad.View.Interface;
using K4nvas.Market.Module.Seguridad.ViewModel.Interface;
using Microsoft.VisualBasic.Devices;
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
    [Export(typeof(ILoginView))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class LoginView : UserControl, ILoginView
    {
        public LoginView()
        {
            InitializeComponent();
        }


        [Import]
        ILoginViewModel ViewModel
        {
            get { return DataContext as ILoginViewModel; }
            set { this.DataContext = value; }
        }

        private void btnIngresar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Log_Loaded(object sender, RoutedEventArgs e)
        {
            txt_Usuario.Focus();
        }



    }
}
