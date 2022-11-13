using Builder.Directors;
using Builder.Entities;

Console.WriteLine("Builder");

Director director = new Director();

Build(director.BuildMegaStacker(2));
Build(director.BuildMegaStacker(4));
Build(director.BuildBigMac());
Build(director.BuildWhooper());

Console.ReadKey();


void Build(Burger burger)
{
    Console.WriteLine(burger.ToString());
}