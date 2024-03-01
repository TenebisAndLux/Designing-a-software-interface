using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PUI_lab5
{
    [Serializable]
    public class Capital
    {
        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlElement("Country")]
        public string Country { get; set; }

        [XmlElement("PartOfTheWorld")]
        public string PartOfTheWorld { get; set; }

        [XmlElement("Population")]
        public string Population { get; set; }

        [XmlElement("Area")]
        public string Area { get; set; }

    }
}
