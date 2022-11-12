using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class DatabaseConnection
    {

        private readonly string ConnectionString;
        public DatabaseConnection(string connectionString)
        {
            ConnectionString = connectionString;
        }


        public void printer()
        {

            Console.WriteLine(ConnectionString);
        }
        
    }
}
