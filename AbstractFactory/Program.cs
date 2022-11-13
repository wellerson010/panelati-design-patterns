using PanelaTI.AbstractFactory.Factories;

Console.WriteLine("Abstract Factory");

Build(new USAGasFactory());
Build(new BrazilGasFactory());

Console.ReadKey();

void Build(IOilGasFactory gasFactory)
{
    var well = gasFactory.BuildWell();
    Console.WriteLine($"Well - {well.Name}");

    var block = gasFactory.BuildBlock();
    Console.WriteLine($"Block - EndDate {block.EndDate.ToString("yyyy-MM-dd")}");
}