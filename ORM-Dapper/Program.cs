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
            IDbConnection connection = new MySqlConnection(connString);
            
            var repo  = new DapperProductRepo(connection);
            
            repo.CreateProduct("newStuff", 20, 1);
            
            var products = repo.GetAllProducts();
            
            foreach (var prod in products)
            {
                Console.WriteLine($"ProductID: {prod.ProductId} | {prod.Name}.");
            }

            Console.WriteLine("Connection object created successfully!");

            /*var repo = new DapperDepartmentRepository(connection);

            var departments = repo.GetAllDepartments();

            foreach (var dept in departments)
            {
                Console.WriteLine($"{dept.DepartmentID} | {dept.Name}.");
            }

            Console.WriteLine("Connection object created successfully!");*/
        }
    }
}
