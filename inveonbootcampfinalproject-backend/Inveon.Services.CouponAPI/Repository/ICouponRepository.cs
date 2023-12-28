using Inveon.Models.DTOs;
using Inveon.Models;

namespace Inveon.Services.CouponAPI.Repository
{
    public interface ICouponRepository
    {
        Task<CouponDto> GetCouponByCode(string couponCode);
    }
}
