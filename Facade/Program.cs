using Facade.Entities;
using Facade.Facades;

Console.WriteLine("Facade para uma requisição HTTP");
Console.WriteLine("Chamando API CatFact via Facade");

CatFact cat = await HTTPFacade.Get<CatFact>("https://catfact.ninja/fact");
Console.WriteLine($"Fato: {cat.fact}. Tamanho: {cat.length}");

string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"api-{Guid.NewGuid()}.json");
Console.WriteLine("Fazendo download do JSON da API CatFact: " + path);

await HTTPFacade.DownloadFile("https://catfact.ninja/fact", path);

Console.WriteLine("Terminado download do JSON da API CatFact: " + path);

Console.ReadKey();