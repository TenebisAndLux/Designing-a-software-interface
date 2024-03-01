using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace lab_5
{
    [Serializable]
    public class Book
    {
        [XmlElement("Autor")]
        public string Autor { get; set; }

        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlElement("Year")]
        public string Year { get; set; }

        [XmlElement("IZD")]
        public string IZD { get; set; }

        [XmlElement("Janr")]
        public string Janr { get; set; }

        [XmlElement("Count")]
        public string Count { get; set; }
    }
}