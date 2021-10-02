using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignDatabaseConnection
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; private set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection (string connection)
        {
            if (String.IsNullOrEmpty(connection))
                throw new InvalidOperationException();
            ConnectionString = connection;
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();

    }
}
