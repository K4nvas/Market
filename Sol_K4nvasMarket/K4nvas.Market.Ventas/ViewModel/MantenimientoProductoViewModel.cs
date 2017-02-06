using K4nvas.Market.Proxies.Ventas.ServicioVentas;
using K4nvas.Market.ServiceController.Ventas;
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
        private readonly VentasServiceController oVentasServiceController = new VentasServiceController();

        [ImportingConstructor]
        public MantenimientoProductoViewModel()
        {
            IsOpenFlyoutMantenimientoProducto = true;
            ListaCategoria = oVentasServiceController.ListarCategoriaProducto();
        }

        #region Entities

        private bool _IsOpenFlyoutMantenimientoProducto;

        public bool IsOpenFlyoutMantenimientoProducto
        {
            get { return _IsOpenFlyoutMantenimientoProducto; }
            set { _IsOpenFlyoutMantenimientoProducto = value;
                OnPropertyChanged(() => IsOpenFlyoutMantenimientoProducto); }
        }

        private ListaCategoria _ListaCategoria;

        public ListaCategoria ListaCategoria
        {
            get { return _ListaCategoria; }
            set { _ListaCategoria = value; OnPropertyChanged(() => ListaCategoria); }
        }

        private Categoria _CategoriaSeleccionada;

        public Categoria CategoriaSeleccionada
        {
            get { return _CategoriaSeleccionada; }
            set { _CategoriaSeleccionada = value; OnPropertyChanged(() => CategoriaSeleccionada); }
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
            IsOpenFlyoutMantenimientoProducto = false;
            Dispose();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }


}
