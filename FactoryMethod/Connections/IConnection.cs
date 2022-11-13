using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Connections
{
    public interface IConnection
    {
        void Connect();

        void Dispose();
    }
}
