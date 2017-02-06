using K4nvas.Market.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K4nvas.Market.Repository.Contract.Ventas
{
    public interface IVentasRepository
    {
        ListaCategoria ListarCategoriaProducto();
    }
}
