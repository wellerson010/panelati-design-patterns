using FactoryMethod.Connections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Framework
    {
        private IConnection? Connection { get; set; }

        public virtual IConnection CreateConnection() => new PostgreSQLConnection();

        public void Start()
        {
            Connection = CreateConnection();
            Connection.Connect();
        }

        public void Exit()
        {
            if (Connection != null)
            {
                Connection.Dispose();
            }
        }
    }
}
