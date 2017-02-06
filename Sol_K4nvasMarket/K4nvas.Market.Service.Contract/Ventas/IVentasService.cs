using K4nvas.Market.Model;
using System.ServiceModel;

namespace K4nvas.Market.Service.Contract.Ventas
{
    [ServiceContract]
    public interface IVentasService
    {
        [OperationContract]
        ListaCategoria ListarCategoriaProducto();
    }
}
