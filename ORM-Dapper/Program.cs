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
            IDbConnection conn = new MySqlConnection(connString);

            var repo = new DapperDepartmentRepository(conn);
            
            var departments = repo.GetAllDepartments();

            foreach (var dept in departments)
            {
                Console.WriteLine($"{dept.DepartmentID}, {dept.Name}.");
            }

            Console.WriteLine("Connection object created successfully!");
        }
    }
}
