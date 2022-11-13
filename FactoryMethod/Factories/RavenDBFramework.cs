using FactoryMethod.Connections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factories
{
    internal class RavenDBFramework:Framework
    {
        public override IConnection CreateConnection() => new RavenDBConnection();
    }
}
