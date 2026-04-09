using System.Data;
using Dapper;

namespace ORM_Dapper;

public class DapperProductRepo  : IProductRepo
{
    private readonly IDbConnection _connection;

    //Constructor - special member method (since it has scope and the same name as class
    //is called when you want to create an instance of the class
    public DapperProductRepo(IDbConnection connection)
    {
        _connection = connection;
    }

    public void CreateProduct(string name, double price, int categoryID)
    {
        _connection.Execute("INSERT INTO products (Name, Price, CategoryID) VALUES (@name, @price, @categoryID);",
            new { name = name, price = price, categoryID = categoryID });
        
    }
    
    public IEnumerable<Product> GetAllProducts()
    {
        //Dapper starts here; extends IDbConnection
        return _connection.Query<Product>("SELECT * FROM Products;");
    }

    public void UpdateProduct(int ProductID, string UpdatedName)
    {
        _connection.Execute("UPDATE Products SET Name = @updatedName Where ProductID = @productID;",
            new { updatedName = UpdatedName,  productID = ProductID });
    }

    public void DeleteProduct(int ProductID)
    {
        _connection.Execute("DELETE FROM reviews WHERE ProductID = @productID;",
            new { productID = ProductID });
        
        _connection.Execute("DELETE FROM sales WHERE ProductID = @productID;",
            new { productID = ProductID });

        _connection.Execute("DELETE FROM products WHERE ProductID = @productID;",
            new { productID = ProductID });
    }
}