using System;

namespace DesignDatabaseConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlconnection = new SqlConnection("sql-connection");
            //sqlconnection.Timeout = TimeSpan.FromSeconds(2); 
            //Console.WriteLine(sqlconnection.Timeout);
            //Console.WriteLine(sqlconnection.ConnectionString);
            //sqlconnection.OpenConnection();
            //sqlconnection.CloseConnection();

            var oracleConnection = new OracleConnection("oracle-connection");
            //oracleConnection.Timeout = TimeSpan.FromSeconds(2);
            //Console.WriteLine(oracleConnection.Timeout);
            //Console.WriteLine(oracleConnection.ConnectionString);
            //oracleConnection.OpenConnection();
            //oracleConnection.CloseConnection();

            var dbCommand = new DbCommand(oracleConnection, "This is the intruction");
            dbCommand.Execute();

        }
    }
}
