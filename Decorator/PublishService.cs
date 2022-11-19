using Decorator.Decorators;
using Decorator.Entities;
using Decorator.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class PublishService
    {
        public static IList<LayerViewModel> Publish(IList<Layer> layers, GenerateViewModel generate)
        {
            IList<LayerViewModel> layersViewModel = new List<LayerViewModel>();
            foreach (Layer layer in layers)
            {
                layersViewModel.Add(generate.Build(layer));
            }

            return layersViewModel;
        }
    }
}
