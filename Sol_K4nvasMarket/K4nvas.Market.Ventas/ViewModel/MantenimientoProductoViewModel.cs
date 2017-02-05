using K4nvas.Market.Ventas.ViewModel.Interface;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Mvvm;
using System;
using System.ComponentModel.Composition;
using System.Windows.Input;

namespace K4nvas.Market.Ventas.ViewModel
{
    [Export(typeof(IMantenimientoProductoViewModel))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class MantenimientoProductoViewModel : BindableBase, IMantenimientoProductoViewModel, IDisposable
    {
        [ImportingConstructor]
        public MantenimientoProductoViewModel()
        {
            IsOpenFlyoutMantenimientoProducto = true;
        }

        #region Entities

        private bool _IsOpenFlyoutMantenimientoProducto;

        public bool IsOpenFlyoutMantenimientoProducto
        {
            get { return _IsOpenFlyoutMantenimientoProducto; }
            set { _IsOpenFlyoutMantenimientoProducto = value;
                OnPropertyChanged(() => IsOpenFlyoutMantenimientoProducto); }
        }


        #endregion

        #region Commands


        public ICommand CommandCerrarMantenimientoProducto
        {
            get { return new DelegateCommand(CerrarMantenimientoProductoCommand); }
        }

        #endregion

        #region Methods

        private void CerrarMantenimientoProductoCommand()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }


}
