using Decorator.Entities;
using Decorator.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public class GenerateViewModel
    {
        public virtual LayerViewModel Build(Layer layer)
        {
            return new LayerViewModel()
            {
                Name = layer.Name,
                Workspace = layer.Workspace,
            };
        }
    }
}
