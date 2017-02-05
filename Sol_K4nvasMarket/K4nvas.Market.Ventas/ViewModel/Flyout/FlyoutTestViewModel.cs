using K4nvas.Market.Ventas.ViewModel.Interface;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace K4nvas.Market.Ventas.ViewModel.Flyout
{
    [Export(typeof(IFlyoutTestViewModel))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class FlyoutTestViewModel : BindableBase,  IFlyoutTestViewModel, IDisposable
    {
        [ImportingConstructor]
        public FlyoutTestViewModel()
        {
            IsOpenFlyoutTestView = true;
        }

        #region Entidades

        private bool _IsOpenFlyoutTestView;

        public bool IsOpenFlyoutTestView
        {
            get { return _IsOpenFlyoutTestView; }
            set { _IsOpenFlyoutTestView = value; OnPropertyChanged(() => IsOpenFlyoutTestView); }
        }

        #endregion

        #region Commands

        public ICommand CommandCerrarFlyoutTest
        {
            get { return new DelegateCommand(CerrarFlyoutTest); }
        }

        #endregion

        #region Métodos


        private void CerrarFlyoutTest()
        {
            IsOpenFlyoutTestView = false;
            Dispose();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}
