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
        private IConnection _connection { get; set; }

        public virtual IConnection CreateConnection() => new PostgreSQLConnection(); 

        public void Start()
        {
            _connection = CreateConnection();
            _connection.Connect();
        }

        public void Exit()
        {
            _connection.Dispose();
        }
    }
}
