using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using Npgsql;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentUsersApp.Models
{
    public class DataAccessController
    {
        // TODO: Add your connection string in the following statements
        string connectionString = "<Azure Database for PostgreSQL Connection String>";

        // Retrieve all details of courses and their modules    
        public IEnumerable<Users> GetAllUsers()
        {
            List<Users> userList = new List<Users>();

            // TODO: Connect to the database
            //using ()

            {
                Console.Out.WriteLine("Opening connection");

                // TODO: Specify the SQL query to run

                // TODO: Execute the query

                // TODO: Read the data a row at a time
            
                // TODO: Close the database connection
            }
            return userList;
        }
    }
}
