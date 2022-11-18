using Adapter.Interfaces;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class ClientJSONReader
    {
        public static void GetJSON(IJSON json)
        {
            JObject obj = json.GetJson();
            Console.WriteLine("Iniciando leitura do JSON");
            foreach (KeyValuePair<string, JToken?> x in obj)
            {
                string property = x.Key;
                string value = x.Value?.ToString() ?? " - ";

                Console.WriteLine($"Propriedade: {property} - Valor: {value}");
            }
            Console.WriteLine("Finalizando leitura do JSON");
        }
    }
}
