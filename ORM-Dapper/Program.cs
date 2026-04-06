using System.Data;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace ORM_Dapper
{
    public class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string connString = config.GetConnectionString("DefaultConnection")!;

            using IDbConnection conn = new MySqlConnection(connString);

            Console.WriteLine("Connection object created successfully!"); //OmniSharp: Restart OmniSharpX
        }
    }
}
