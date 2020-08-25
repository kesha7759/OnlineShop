using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OnlineShop.Models
{
    [Serializable]
    public class Good
    {
        public int GoodID { get; set; }
        [XmlAttribute("Name")]
        public string Name { get; set; }
        [XmlAttribute("Value")]
        public decimal Value { get; set; }
        [XmlAttribute("Articul")]
        public string Articul { get; set; }
    }
}
