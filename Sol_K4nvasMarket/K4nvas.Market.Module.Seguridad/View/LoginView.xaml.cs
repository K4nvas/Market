using K4nvas.Market.Module.Seguridad.View.Interface;
using K4nvas.Market.Module.Seguridad.ViewModel.Interface;
using System.ComponentModel.Composition;
using System.Windows;
using System.Windows.Controls;

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
