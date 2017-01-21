using K4nvas.Market.Shell.ViewModel.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K4nvas.Market.Shell.ViewModel
{
    [Export(typeof(IShellViewModel))]
    public class ShellViewModel : IShellViewModel
    {
        public ShellViewModel()
        {

        }
    }
}
