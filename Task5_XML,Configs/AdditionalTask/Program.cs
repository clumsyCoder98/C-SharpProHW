using System;
using System.Xml;

namespace AdditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var document = new XmlTextWriter("TelephoneBook.xml", null);

            document.Formatting = Formatting.Indented;
            document.IndentChar = '\t';
            document.Indentation = 1;

            document.WriteStartDocument();
            document.WriteStartElement("MyContacts");
            document.WriteStartElement("Contact");
            document.WriteStartAttribute("TelephoneNumber");
            document.WriteString("0441234567");
            document.WriteEndAttribute();
            document.WriteString("Name Example");
            document.WriteEndElement();
            document.WriteEndElement();

            document.Close();

        }
    }
}
