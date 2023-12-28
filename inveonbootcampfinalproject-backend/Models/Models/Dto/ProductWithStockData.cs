namespace Inveon.Models.DTOs;

public class ProductWithStockData
{
    public Product productData { get; set; }
    public IEnumerable<ProductStock> stockData{ get; set; }
}