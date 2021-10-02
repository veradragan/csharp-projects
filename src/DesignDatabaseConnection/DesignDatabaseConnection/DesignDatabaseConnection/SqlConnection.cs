using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignDatabaseConnection
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connection)
            :base (connection)
        {
            Console.WriteLine("Connection for Sql");
        }

        public override void OpenConnection()
        {
            //if (Timeout.TotalSeconds == 2)
            //    throw new TimeoutException();

            //var start = DateTime.Now;
            //while (true)
            //{
            //    open the underlying connection with sql api
            //     if theses api calls take more than the given TimeOut
            //     then throw timeout exception

            //    var elapsedSeconds = (DateTime.Now - start).TotalSeconds;
            //    if (elapsedSeconds >= Timeout.TotalSeconds)
            //    {
            //        throw new TimeoutException();
            //    }
            //}

            //wait for connection to be established(timeout)

            Console.WriteLine("Sql connection opened");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Sql connection closed");
        }
    }
}
