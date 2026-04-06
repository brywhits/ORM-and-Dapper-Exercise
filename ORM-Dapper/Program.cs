using System.Data;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace ORM_Dapper
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Reads your appsettings.json
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            //Pulls out the connection string for MySQL
            //! → tells the compiler “I promise this won’t be null”
            string connString = config.GetConnectionString("DefaultConnection")!;

            //Creates a MySQL database connection object
            //Using → ensures that the connection is closed and disposed automatically when done
            using IDbConnection conn = new MySqlConnection(connString);

            Console.WriteLine("Connection object created successfully!"); //OmniSharp: Restart OmniSharpX
        }
    }
}
