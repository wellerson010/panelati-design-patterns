using Decorator.Entities;
using Decorator.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public class AddCreationDateDecorator : GenerateViewModel
    {
        private readonly GenerateViewModel _wrapper;

        public AddCreationDateDecorator(GenerateViewModel wrapper)
        {
            _wrapper = wrapper;
        }
        public override LayerViewModel Build(Layer layer)
        {
            LayerViewModel viewModel = _wrapper.Build(layer);

            viewModel.CustomData.Add("creationDate", layer.CreationDate.ToString("yyyy-MM-dd"));

            return viewModel;
        }
    }
}
