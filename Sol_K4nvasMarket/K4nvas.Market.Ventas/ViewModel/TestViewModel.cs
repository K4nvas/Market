using K4nvas.Market.Ventas.ViewModel.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K4nvas.Market.Ventas.ViewModel
{
    [Export(typeof(ITestViewModel))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class TestViewModel : ITestViewModel
    {

        [ImportingConstructor]
        public TestViewModel()
        {

        }
    }
}
