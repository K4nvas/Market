using K4nvas.Market.Ventas.ViewModel.Interface;
using System.ComponentModel.Composition;

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
