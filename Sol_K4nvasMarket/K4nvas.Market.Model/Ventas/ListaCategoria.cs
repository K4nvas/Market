using System.Collections.Generic;
using System.Runtime.Serialization;

namespace K4nvas.Market.Model
{
    [CollectionDataContract]
    public class ListaCategoria : List<Categoria>
    {
    }
}
