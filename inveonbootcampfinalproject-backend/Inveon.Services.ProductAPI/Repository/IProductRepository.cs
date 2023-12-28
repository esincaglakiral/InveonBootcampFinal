using Inveon.Models.DTOs;
using Inveon.Models;

namespace Inveon.Services.ProductAPI.Repository
{
    public interface IProductRepository
    {

        //crud  create read update delete  
        Task<IEnumerable<ProductDto>> GetProducts();
        Task<ProductWithStockData> GetProductById(int productId);
        Task<ProductDto> CreateUpdateProduct(ProductDto productDto);
        Task<bool> DeleteProduct(int productId);
    }
}
