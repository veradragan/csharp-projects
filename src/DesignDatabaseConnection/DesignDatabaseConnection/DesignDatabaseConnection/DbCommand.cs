using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignDatabaseConnection
{
    public class DbCommand
    {
        public string Instruction { get; set; }
        private DbConnection _dbConnection;
        private string _instruction;
        
        public DbCommand(DbConnection connection, string instruction)
        {
            if (connection == null)
                throw new InvalidOperationException();

            if (String.IsNullOrEmpty(instruction))
                throw new InvalidOperationException();

            _dbConnection = connection;
            _instruction = instruction;
        }

        public void Execute()
        {
            _dbConnection.OpenConnection();
            Console.WriteLine(_instruction);
            _dbConnection.CloseConnection();
            //Console.WriteLine("This is execute method");  
        }
    }
}
