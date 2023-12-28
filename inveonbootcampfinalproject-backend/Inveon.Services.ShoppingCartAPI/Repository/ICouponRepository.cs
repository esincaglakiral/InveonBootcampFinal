using Inveon.Models;
using Inveon.Models.DTOs;

namespace Inveon.Services.ShoppingCartAPI.Repository
{
    public interface ICouponRepository
    {
        Task<CouponDto> GetCoupon(string couponName);
    }
}
