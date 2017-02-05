using System;
using System.Runtime.Serialization;

namespace K4nvas.Market.Model.Test
{
    [DataContract]
    public class TestData
    {
        [DataMember]
        public int IdTest { get; set; }
        [DataMember]
        public string DescriptionTest { get; set; }
        [DataMember]
        public DateTime DateTest { get; set; } 
    }
}
