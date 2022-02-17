using System;
using System.Xml.Serialization;

namespace Task2
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
