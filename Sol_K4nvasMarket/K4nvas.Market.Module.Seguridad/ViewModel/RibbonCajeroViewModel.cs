using K4nvas.Market.Common.Helpers;
using K4nvas.Market.Module.Seguridad.ViewModel.Interface;
using K4nvas.Market.Ventas.View.Interface;
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
    [Export(typeof(IRibbonCajeroViewModel))]
    public class RibbonCajeroViewModel : BindableBase , IRibbonCajeroViewModel
    {
        [ImportingConstructor]
        public RibbonCajeroViewModel()
        {

        }


        #region Entidades

        #endregion

        #region Commands

        public ICommand CommandCaja
        {
            get { return new DelegateCommand(CajaCommand); }
        }

        public ICommand CommandProducto
        {
            get { return new DelegateCommand(ProductoCommand); }
        }

        public ICommand CommandReporte
        {
            get { return new DelegateCommand(ReporteCommand); }
        }

        #endregion

        #region Métodos
        private void CajaCommand()
        {
            ViewActivator<ITestView>.Instance.Activate();
        }

        private void ProductoCommand()
        {
            ViewActivator<IProductoView>.Instance.Activate();
        }

        private void ReporteCommand()
        {
            throw new NotImplementedException();
        }


        #endregion
    }
}
