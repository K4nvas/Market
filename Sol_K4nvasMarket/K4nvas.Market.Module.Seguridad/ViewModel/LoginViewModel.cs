using K4nvas.Market.Module.Seguridad.ViewModel.Interface;
using MahApps.Metro.Controls.Dialogs;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace K4nvas.Market.Module.Seguridad.ViewModel
{
    [Export(typeof(ILoginViewModel))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class LoginViewModel  : BindableBase, ILoginViewModel
    {
        [ImportingConstructor]
        public LoginViewModel()
        {

        }


        #region Entidades

        private string _Usuario;

        public string Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; OnPropertyChanged(()=> Usuario); }
        }

        private string _Contrasenia;

        public string Contrasenia
        {
            get { return _Contrasenia; }
            set { _Contrasenia = value; OnPropertyChanged(() => Contrasenia); }
        }



        #endregion

        #region Commands

        public ICommand CommandLogin
        {
            get { return new DelegateCommand(LoginCommand); }
        }

        #endregion

        #region Métodos

        private async void LoginCommand()
        {
            //if(string.IsNullOrEmpty(Usuario) || string.IsNullOrEmpty(Contrasenia))
            //{

            //    return;
            //}

            var mySettings = new MetroDialogSettings()
            {
                AffirmativeButtonText = "OK",
                ColorScheme = MetroDialogColorScheme.Accented
            };

            //MessageDialogResult result = await ShowMessageAsync("Hello!", "Welcome to the world of metro!",
            //    MessageDialogStyle.AffirmativeAndNegativeAndSingleAuxiliary, mySettings);

        }

        #endregion
    }
}
