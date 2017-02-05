using K4nvas.Market.Ventas.ViewModel.Flyout;
using K4nvas.Market.Ventas.ViewModel.Interface;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Mvvm;
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



        #endregion

        #region Commands

        public ICommand CommandAbrirFlyoutTest
        {
            get { return new DelegateCommand(AbrirFlyoutTestCommand); }
        }

        #endregion

        #region Métodos

        private void AbrirFlyoutTestCommand()
        {
            FlyoutTestViewModel = new FlyoutTestViewModel();
        }

        #endregion
    }
}
