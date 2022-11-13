using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Connections
{
    public class PostgreSQLConnection : IConnection
    {
        public void Connect()
        {
            Console.WriteLine("Conectado ao banco de dados PostgreSQL");
        }

        public void Dispose()
        {
            Console.WriteLine("Liberado conexão ao banco de dados PostgreSQL");
        }
    }
}
