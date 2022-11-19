using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Entities
{
    public class Layer
    {
        public string Name { get; set; } = "";
        public string Workspace { get; set; } = "";
        public DateTime CreationDate { get; set; }
        public string Company { get; set; } = "";
    }
}
