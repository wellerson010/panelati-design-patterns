using Decorator;
using Decorator.Decorators;
using Decorator.Entities;
using Decorator.Utils;
using Decorator.ViewModels;

Console.WriteLine("Iniciando Decorator");

IList<Layer>? layers = GenerateFakeData.CreateData();

var generateViewModel = new AddCreationDateDecorator(new AddCompanyDecorator(new GenerateViewModel()));

IList<LayerViewModel>? viewModels = PublishService.Publish(layers, generateViewModel);

foreach(LayerViewModel? viewModel in viewModels)
{
    Console.WriteLine(viewModel);
}


Console.ReadKey();