using System.Security.Claims;
using Inveon.Models;
using Inveon.Models.DTOs;
using Inveon.Services.ShoppingCartAPI.RabbitMQSender;
using Inveon.Services.ShoppingCartAPI.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Inveon.Services.ShoppingCartAPI.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("api/cart")]
    public class CartAPIController : ControllerBase
    {
        private readonly ICartRepository _cartRepository;
        private readonly ICouponRepository _couponRepository;
        protected ResponseDto _response;
        private readonly IRabbitMQCartMessageSender _rabbitMQCartMessageSender;
        public CartAPIController(ICartRepository cartRepository,
            ICouponRepository couponRepository, IRabbitMQCartMessageSender rabbitMQCartMessageSender)
        {
            _cartRepository = cartRepository;
            _couponRepository = couponRepository;
            _rabbitMQCartMessageSender = rabbitMQCartMessageSender;
            //_messageBus = messageBus;
            this._response = new ResponseDto();
        }
        
        [Authorize]
        [HttpGet("GetCart/")]
        public async Task<object> GetCart()
        {
            ClaimsPrincipal currentUser = this.User;
            string userId = currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;
            
            try
            {
                List <CartDetails> cartDetails = await _cartRepository.GetCartByUserId(userId);
                _response.Result = cartDetails;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }



        [HttpPost]
        [Authorize]
        public async Task<object> Post([FromBody] CartDto cartDto)
        {
            try
            {
                if (cartDto.CartHeader.CouponCode == null)
                {
                    cartDto.CartHeader.CouponCode = ""; //
                }
                // CartDto model = await _cartRepository.CreateUpdateCart(cartDto);
                // _response.Result = model;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages
                     = new List<string>() { ex.ToString() };
            }
            return _response;
        }
        
        [Authorize]
        [HttpPost("AddProductToCart")]
        public async Task<object> AddProductToCart([FromBody] AddItemToCartInfo info)
        {
            ClaimsPrincipal currentUser = this.User;
            string userId = currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;
            
            try
            { 
                await _cartRepository.AddProductToCart(userId, info.productId, info.size, info.count);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages
                     = new List<string>() { ex.ToString() };
            }
            return _response;
        }
        [Authorize]
        [HttpDelete("DeleteProductFromCart")]
        public async Task<object> DeleteProductFromCart([FromBody] AddItemToCartInfo info)
        {
            ClaimsPrincipal currentUser = this.User;
            string userId = currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;
            
            try
            { 
                await _cartRepository.DeleteProductFromCart(userId, info.productId, info.size);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages
                     = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpPost("UpdateCart")]
        public async Task<object> UpdateCart(CartDto cartDto)
        {
            try
            {
                // CartDto cartDt = await _cartRepository.CreateUpdateCart(cartDto);
                // _response.Result = cartDt;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpPost("RemoveCart")]
        public async Task<object> RemoveCart([FromBody] int cartId)
        {
            try
            {
                bool isSuccess = await _cartRepository.RemoveFromCart(cartId);
                _response.Result = isSuccess;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpPost("ApplyCoupon")]
        public async Task<object> ApplyCoupon([FromBody] CartDto cartDto)
        {
            try
            {
                bool isSuccess = await _cartRepository.ApplyCoupon(cartDto.CartHeader.UserId,
                    cartDto.CartHeader.CouponCode);
                _response.Result = isSuccess;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpPost("RemoveCoupon")]
        public async Task<object> RemoveCoupon([FromBody] string userId)
        {
            try
            {
                bool isSuccess = await _cartRepository.RemoveCoupon(userId);
                _response.Result = isSuccess;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }




        [HttpPost("Checkout2")]
        public async Task<object> Checkout2(CartDto cartDto)
        {
            try
            {
                if (!string.IsNullOrEmpty(cartDto.CartHeader.CouponCode))
                {
                    CouponDto coupon = await _couponRepository.GetCoupon(cartDto.CartHeader.CouponCode);

                }

                await _cartRepository.ClearCart(cartDto.CartHeader.UserId);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }
    }
}
