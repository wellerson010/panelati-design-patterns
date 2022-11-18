using Adapter.Interfaces;
using Adapter.Reader;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Adapters
{
    public class FileAdapter : IJSON
    {
        private readonly FileReader _reader;

        public FileAdapter(FileReader reader)
        {
            _reader = reader;
        }

        public JObject GetJson()
        {
            JObject json = new JObject();
            string text = _reader.GetFile();

            List<JProperty>? items = text.Split("\r\n").Select(x =>
            {
                string[] parts = x.Split('=');
                return new JProperty(parts[0], new JValue(parts[1]));
            }).ToList();

            json.Add(items);

            return json;
        }
    }
}
