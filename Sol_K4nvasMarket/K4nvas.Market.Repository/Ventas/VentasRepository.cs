using K4nvas.Market.Repository.Contract.Ventas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using K4nvas.Market.Model;

namespace K4nvas.Market.Repository.Ventas
{
    public class VentasRepository : IVentasRepository
    {
        public ListaCategoria ListarCategoriaProducto()
        {
            ListaCategoria oListaCategoria = new ListaCategoria();
            oListaCategoria.Add(new Categoria { IdCategoria = 1, Descripcion = "COMESTIBLES" });
            oListaCategoria.Add(new Categoria { IdCategoria = 2, Descripcion = "BEBIDAS" });
            oListaCategoria.Add(new Categoria { IdCategoria = 2, Descripcion = "EMPAQUETADOS" });
            oListaCategoria.Add(new Categoria { IdCategoria = 2, Descripcion = "NO EMPAQUETADOS" });
            oListaCategoria.Add(new Categoria { IdCategoria = 2, Descripcion = "GALLETAS" });
            return oListaCategoria;
        }
    }
}
