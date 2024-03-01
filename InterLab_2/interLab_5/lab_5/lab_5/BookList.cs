using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace lab_5
{
    [Serializable]
    [XmlRoot("NewDataSet")]
    public class BookList
    {
        [XmlElement("Books")]
        public List<Book> Items { get; set; }
    
        public BookList()
        {
            Items = new List<Book>();
        }
    }
}
