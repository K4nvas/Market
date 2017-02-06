using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using K4nvas.Market.Proxies.Ventas.ServicioVentas;

namespace K4nvas.Market.ServiceController.Ventas
{
    public class VentasServiceController
    {
        public ListaCategoria ListarCategoriaProducto()
        {
            using (VentasServiceClient oVentasServiceClient = new VentasServiceClient())
            {
                return oVentasServiceClient.ListarCategoriaProducto();
            }
        }
    }
}
