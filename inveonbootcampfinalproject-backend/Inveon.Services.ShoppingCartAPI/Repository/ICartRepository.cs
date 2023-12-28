using Inveon.Models;
using Inveon.Models.DTOs;

namespace Inveon.Services.ShoppingCartAPI.Repository
{
    public interface ICartRepository
    {
        Task<List<CartDetails>> GetCartByUserId(string userId);

        Cart GetCartByUserIdNonAsync(string userId);
        // Task<CartDto> CreateUpdateCart(CartDto cartDto);
        Task<bool> AddProductToCart(string userId, int productId, string size, int count);
        Task<bool> RemoveFromCart(int cartDetailsId);
        Task<bool> ApplyCoupon(string userId, string couponCode);
        Task<bool> RemoveCoupon(string userId);
        Task<bool> ClearCart(string userId);
        Task<bool> DeleteProductFromCart(string userId, int productId, string size);
    }
}
