using FactoryMethod;
using FactoryMethod.Factories;

Console.WriteLine("Factory Method");

Console.WriteLine("Primeiro com PostgreSQL, depois com RavenDB");

Build(new PostgreSQLFramework());
Build(new RavenDBFramework());

Console.ReadKey();

void Build(Framework framework)
{
    framework.Start();
    framework.Exit();
}