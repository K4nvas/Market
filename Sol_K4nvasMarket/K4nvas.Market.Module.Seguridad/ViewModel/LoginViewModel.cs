using K4nvas.Market.Module.Seguridad.ViewModel.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K4nvas.Market.Module.Seguridad.ViewModel
{
    [Export(typeof(ILoginViewModel))]
    [PartCreationPolicy(CreationPolicy.Shared)]
    public class LoginViewModel  : ILoginViewModel
    {
        [ImportingConstructor]
        public LoginViewModel()
        {

        }
    }
}
