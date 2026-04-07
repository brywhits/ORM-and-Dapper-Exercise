namespace ORM_Dapper;

public interface IProductRepo
{
    //stubbed out methods because they have no scope
    //IEnumerable specifies how a collection should behave
    IEnumerable<Product> GetAllProducts();
    
    void CreateProduct(string name, double price, int categoryID);
}