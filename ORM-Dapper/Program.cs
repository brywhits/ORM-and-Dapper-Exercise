using System.Data;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;


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
            using IDbConnection conn = new MySqlConnection(connString);

            Console.WriteLine("Connection object created successfully!"); //OmniSharp: Restart OmniSharpX
        }
    }
}
