using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Reader
{
    public class FileReader
    {
        public string GetFile()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Files", "person.txt");

            return File.ReadAllText(path);
        }
    }
}
