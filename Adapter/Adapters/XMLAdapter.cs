using Adapter.Interfaces;
using Adapter.Reader;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Adapter.Adapters
{
    public class XMLAdapter : IJSON
    {
        private readonly XMLReader _reader;

        public XMLAdapter(XMLReader reader)
        {
            _reader = reader;
        }
        public JObject GetJson()
        {
            XDocument xml = _reader.GetXML();
            JObject json = new JObject();

            if (xml.Root != null)
            {
                foreach (XElement item in xml.Root.Elements())
                {
                    string property = item.Name.LocalName;
                    string value = item.Value;

                    json.Add(new JProperty(property, value));
                }
            }

            return json;
        }
    }
}
