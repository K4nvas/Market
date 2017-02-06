using K4nvas.Market.Service.Contract.Ventas;
using K4nvas.Market.Model;
using K4nvas.Market.Domain.Contract.Ventas;

namespace K4nvas.Market.Service.Ventas
{
    public class VentasService : IVentasService
    {

        private readonly IVentasDomain IVentasDomain;

        public VentasService(IVentasDomain IVentasDomain)
        {
            this.IVentasDomain = IVentasDomain;
        }


        public ListaCategoria ListarCategoriaProducto()
        {
            return IVentasDomain.ListarCategoriaProducto();
        }
    }
}
