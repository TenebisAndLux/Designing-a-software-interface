using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PUI_lab5
{
    [Serializable]
    [XmlRoot("NewDataSet")]
    public class CapitalList
    {
        [XmlElement("Capital")]
        public List<Capital> Items { get; set; }
        public CapitalList()
        {
            Items = new List<Capital>();
        }
    }
}
