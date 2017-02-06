using K4nvas.Market.Ventas.ViewModel.Flyout;
using K4nvas.Market.Ventas.ViewModel.Interface;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Mvvm;
using System;
using System.ComponentModel.Composition;
using System.Windows.Input;

namespace K4nvas.Market.Ventas.ViewModel
{
    [Export(typeof(IProductoViewModel))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class ProductoViewModel : BindableBase, IProductoViewModel
    {
        [ImportingConstructor]
        public ProductoViewModel()
        {

        }


        #region Entidades

        private FlyoutTestViewModel _FlyoutTestViewModel;

        public FlyoutTestViewModel FlyoutTestViewModel
        {
            get { return _FlyoutTestViewModel; }
            set { _FlyoutTestViewModel = value; OnPropertyChanged(() => FlyoutTestViewModel); }
        }

        private MantenimientoProductoViewModel _MantenimientoProductoViewModel;

        public MantenimientoProductoViewModel MantenimientoProductoViewModel
        {
            get { return _MantenimientoProductoViewModel; }
            set { _MantenimientoProductoViewModel = value;
                OnPropertyChanged(() => MantenimientoProductoViewModel);
            }
        }


        #endregion

        #region Commands


        public ICommand CommandNuevoProducto
        {
            get { return new DelegateCommand(NuevoProductoCommand); }
        }

        //public ICommand CommandAbrirFlyoutTest
        //{
        //    get { return new DelegateCommand(AbrirFlyoutTestCommand); }
        //}

        #endregion

        #region Métodos

        private void NuevoProductoCommand()
        {
            MantenimientoProductoViewModel = new MantenimientoProductoViewModel();
        }

        #endregion
    }
}
