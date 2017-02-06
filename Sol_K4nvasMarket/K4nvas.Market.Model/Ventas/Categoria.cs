using System.Runtime.Serialization;

namespace K4nvas.Market.Model
{
    [DataContract]
    public class Categoria
    {
        [DataMember]
        public int IdCategoria { get; set; }
        [DataMember]
        public string Descripcion { get; set; }
        [DataMember]
        public string DescripcionCorta { get; set; }
        [DataMember]
        public bool FlagEstado { get; set; }
    }
}
