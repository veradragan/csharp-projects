using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignDatabaseConnection
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string conection)
            :base (conection)
        {
            Console.WriteLine("Connection for Oracle");
        }

        public override void OpenConnection()
        {
            if (Timeout.TotalSeconds == 2)
                throw new TimeoutException();
            Console.WriteLine("Oracle connection opened");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Oracle connection closed");
        }
    }
}
