using FactoryMethod.Factories;

Console.WriteLine("Factory Method");

Console.WriteLine("Primeiro com PostgreSQL, depois com RavenDB");

var postgreSQL = new PostgreSQLFramework();
postgreSQL.Start();
postgreSQL.Exit();

var ravenDB = new RavenDBFramework();
ravenDB.Start();
ravenDB.Exit();

Console.ReadKey();