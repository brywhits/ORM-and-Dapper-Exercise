namespace ORM_Dapper;

public class Product
{
    // add each column from dB product table as properties
    public int ProductId { get; set; } // get;set = read;write
    public string Name { get; set; }
    public double Price { get; set; }
    public int CategoryId { get; set; }
    public int OnSale { get; set; }
    public string StockLevel  { get; set; }
}