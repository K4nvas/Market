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
    public partial class LoginView : UserControl
    {
        Computer oComputer = new Computer();

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

        private void Clave_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.CapsLock)
            {
                if (oComputer.Keyboard.CapsLock)
                {
                    ErrorMsg.Text = "Bloq Mayús Activado!";
                }
                else
                {
                    ErrorMsg.Text = string.Empty;
                }
            }
        }

        private void Clave_GotFocus(object sender, RoutedEventArgs e)
        {
            if (oComputer.Keyboard.CapsLock)
            {
                ErrorMsg.Text = "Bloq Mayús Activado!";
            }
            else
            {
                ErrorMsg.Text = string.Empty;
            }
        }

        private void Clave_LostFocus(object sender, RoutedEventArgs e)
        {
            ErrorMsg.Text = string.Empty;
        }

        private void ucLogin_Loaded(object sender, RoutedEventArgs e)
        {
            txtUser.Focus();
        }
    }
}
