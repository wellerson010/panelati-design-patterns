using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.ViewModels
{
    public class LayerViewModel
    {
        public string Name { get; set; } = "";

        public string Workspace { get; set; } = "";

        public Dictionary<string, string> CustomData = new Dictionary<string, string>();

        public override string ToString()
        {
            return $@"Nome: {Name}
                     Workspace: {Workspace}
                     CustomData: {String.Join(" / ", CustomData.Select(x => x.Key + " - " + x.Value))}";
        }
    }
}
