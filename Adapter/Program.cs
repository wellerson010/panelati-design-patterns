using Adapter;
using Adapter.Adapters;
using Adapter.Reader;

Console.WriteLine("Iniciando adapter");

XMLReader xmlReader = new XMLReader();
XMLAdapter xmlAdapter = new XMLAdapter(xmlReader);

FileReader fileReader = new FileReader();
FileAdapter fileAdapter = new FileAdapter(fileReader);

ClientJSONReader.GetJSON(xmlAdapter);
ClientJSONReader.GetJSON(fileAdapter);

Console.ReadKey();

