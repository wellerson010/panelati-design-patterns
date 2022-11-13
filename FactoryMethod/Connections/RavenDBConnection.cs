using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Connections
{
    public class RavenDBConnection:IConnection
    {
        public void Connect()
        {
            Console.WriteLine("Conectado ao banco que o Praia diz existir...");
        }

        public void Dispose()
        {
            Console.WriteLine("Liberando conexão do banco imaginário do Praia...");
        }
    }
}
