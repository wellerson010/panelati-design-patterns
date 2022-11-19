using Decorator.Entities;
using Decorator.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public class AddCompanyDecorator:GenerateViewModel
    {
        private readonly GenerateViewModel _wrapper;

        public AddCompanyDecorator(GenerateViewModel wrapper)
        {
            _wrapper = wrapper;
        }

        public override LayerViewModel Build(Layer layer)
        {
            LayerViewModel model = _wrapper.Build(layer);

            model.CustomData.Add("company", layer.Company);

            return model;
        }
    }
}
