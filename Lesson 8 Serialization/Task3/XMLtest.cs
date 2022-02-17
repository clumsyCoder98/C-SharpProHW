using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task3
{
    [XmlRoot("UserProfile")]
    public class XMLtest
    {
        public string name, surname;
        [XmlAttribute("Country")]
        public string country;
        [XmlIgnore]
        public string overall;
        public XMLtest()
        {
        }
    }
}
