using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Adapter.Reader
{
    public class XMLReader
    {
        public XDocument GetXML()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Files", "person.xml");

            XDocument xmlDoc = XDocument.Load(path);

            return xmlDoc;
        }
    }
}
