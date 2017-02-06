using K4nvas.Market.Domain.Contract.Ventas;
using System;
using K4nvas.Market.Model;
using K4nvas.Market.Repository.Contract.Ventas;

namespace K4nvas.Market.Domain.Ventas
{
    public class VentasDomain : IVentasDomain
    {
        private readonly IVentasRepository oIVentasRepository;

        public VentasDomain(IVentasRepository IVentasRepositoryP)
        {
            oIVentasRepository = IVentasRepositoryP;
        }
        

        public ListaCategoria ListarCategoriaProducto()
        {
            return oIVentasRepository.ListarCategoriaProducto();
        }
    }
}
