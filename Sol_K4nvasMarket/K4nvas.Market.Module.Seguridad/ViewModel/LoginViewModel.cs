using K4nvas.Market.Common.Helpers;
using K4nvas.Market.Common.Helpers.ViewActivator;
using K4nvas.Market.Common.Infraestructure;
using K4nvas.Market.Module.Seguridad.View.Interface;
using K4nvas.Market.Module.Seguridad.ViewModel.Interface;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Mvvm;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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

        private void LoginCommand()
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

            //await ((MetroWindow)Application.Current.MainWindow).ShowMessageAsync("asd", "asd");

            //MessageDialogResult result = await ShowMessageAsync("Hello!", "Welcome to the world of metro!",
            //    MessageDialogStyle.AffirmativeAndNegativeAndSingleAuxiliary, mySettings);

            LimpiarRegionLogin();
            LimpiarRegionRibbon();
            RibbonActivator<IRibbonCajeroView>.Instance.Activate();
            ViewActivator<IHomeView>.Instance.Activate();
        }

        private void LimpiarRegionLogin()
        {
            IRegionManager regionManager;
            regionManager = ServiceLocator.Current.GetInstance<Microsoft.Practices.Prism.Regions.IRegionManager>();
            IRegion logonRegion = regionManager.Regions[RegionNames.LogonRegion];
            foreach (var view in logonRegion.Views)
            {
                logonRegion.Remove(view);
            }
        }

        private void LimpiarRegionRibbon()
        {
            IRegionManager regionManager;
            regionManager = ServiceLocator.Current.GetInstance<IRegionManager>();
            IRegion logonRegion = regionManager.Regions[RegionNames.RibbonRegion];
            foreach (var view in logonRegion.Views)
            {
                logonRegion.Remove(view);
            }
        }

        #endregion
    }
}
