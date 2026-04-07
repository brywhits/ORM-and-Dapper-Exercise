using System.Data;

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
    
    public IEnumerable<Product> GetAllProducts()
    {
        throw new NotImplementedException();
    }

    public void CreateProduct(string name, double price, int categoryID)
    {
        throw new NotImplementedException();
    }
}