using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Iyzipay.Request;
using Iyzipay.Model;
using Iyzipay;
using Inveon.Services.ShoppingCartAPI.RabbitMQSender;
using Inveon.Services.ShoppingCartAPI.Repository;
using Inveon.Models;
using Inveon.Models.DTOs;
using System.Text.Json;
using Newtonsoft.Json;
using HttpClient = System.Net.Http.HttpClient;

namespace Inveon.Service.ShoppingCartAPI.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("api/cartc")]
    public class CartAPICheckOutController : ControllerBase
    {

        private readonly ICartRepository _cartRepository;
        private readonly ICouponRepository _couponRepository;
        // private readonly IMessageBus _messageBus;
        protected ResponseDto _response;
        private readonly IRabbitMQCartMessageSender _rabbitMQCartMessageSender;

        private HttpClient _httpClient;
        // IMessageBus messageBus,
        public CartAPICheckOutController(ICartRepository cartRepository,
            ICouponRepository couponRepository, IRabbitMQCartMessageSender rabbitMQCartMessageSender,
            HttpClient httpClient)
        {
            _cartRepository = cartRepository;
            _couponRepository = couponRepository;
            _rabbitMQCartMessageSender = rabbitMQCartMessageSender;
            //_messageBus = messageBus;
            this._response = new ResponseDto();
            _httpClient = httpClient;
        }

        // Payment method
        [Authorize]
        [HttpPost("checkout")]
        public async Task<object> Checkout([FromBody] CheckoutHeaderDto checkoutHeaderDto)
        {
            ClaimsPrincipal currentUser = this.User;
            string userId = currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;
            try
            {
                Cart cart = _cartRepository.GetCartByUserIdNonAsync(userId);
                if (cart == null)
                {
                    return BadRequest();
                }

                
                CheckoutHeader checkoutHeader = new CheckoutHeader();
                checkoutHeader.UserId = userId;
                checkoutHeader.OrderTotal = checkoutHeaderDto.OrderTotal;
                checkoutHeader.FirstName = checkoutHeaderDto.FirstName;
                checkoutHeader.LastName = checkoutHeaderDto.LastName;
                checkoutHeader.Phone = checkoutHeaderDto.Phone;
                checkoutHeader.Email = checkoutHeaderDto.Email;
                checkoutHeader.CardNumber = checkoutHeaderDto.CardNumber;
                checkoutHeader.CVV = checkoutHeaderDto.CVV;
                checkoutHeader.ExpiryMonth = checkoutHeaderDto.ExpiryMonth;
                checkoutHeader.ExpiryYear = checkoutHeaderDto.ExpiryYear;
                checkoutHeader.CartDetailsList = cart.CartDetails;
                checkoutHeader.cartHeader = cart.CartHeader;
                
                List<Product> productsFromDb = new List<Product>();
                foreach (CartDetails cartDetails in checkoutHeader.CartDetailsList)
                {
                    var hrm = await 
                        _httpClient.GetAsync($"http://localhost:5003/api/products/{cartDetails.ProductId.ToString()}");
                    string jsonContent = await hrm.Content.ReadAsStringAsync();
                    RootObject response = JsonConvert.DeserializeObject<RootObject>(jsonContent);
                    Product product = response.Result.productData;
                    productsFromDb.Add(product);
                }

                CheckoutHeaderWithProducts chwp = new CheckoutHeaderWithProducts();
                chwp.UserId = userId;
                chwp.OrderTotal = checkoutHeaderDto.OrderTotal;
                chwp.FirstName = checkoutHeaderDto.FirstName;
                chwp.LastName = checkoutHeaderDto.LastName;
                chwp.Phone = checkoutHeaderDto.Phone;
                chwp.Email = checkoutHeaderDto.Email;
                chwp.CardNumber = checkoutHeaderDto.CardNumber;
                chwp.CVV = checkoutHeaderDto.CVV;
                chwp.ExpiryMonth = checkoutHeaderDto.ExpiryMonth;
                chwp.ExpiryYear = checkoutHeaderDto.ExpiryYear;
                chwp.CartDetailsList = cart.CartDetails;
                chwp.cartHeader = cart.CartHeader;
                chwp.Products = productsFromDb;
                
                Payment payment = await OdemeIslemi(checkoutHeader, productsFromDb);
                if (payment.Status != "success")
                {
                    _response.IsSuccess = false;
                    _response.ErrorMessages = new List<string>() {payment.ErrorMessage};
                    return _response;
                }

                _rabbitMQCartMessageSender.SendMessage(checkoutHeaderDto, "checkoutqueue");
                _rabbitMQCartMessageSender.SendMessage(chwp, "informQueue");
                await _cartRepository.ClearCart(checkoutHeader.UserId);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }
        
        public class RootObject
        {
            public bool IsSuccess { get; set; }
            public ProductWithStockData Result { get; set; }
            public string DisplayMessage { get; set; }
            public object ErrorMessages { get; set; } // You might want to replace 'object' with the actual type
        }
        public async Task<Payment> OdemeIslemi(CheckoutHeader checkoutHeader, List<Product> products)
        {

            Cart cart = new Cart();
            cart.CartHeader = checkoutHeader.cartHeader;
            cart.CartDetails = checkoutHeader.CartDetailsList;

            //CartDto cartDto = checkoutHeaderDto.CartDetails;
            Options options = new Options();

            options.ApiKey = "sandbox-Y6LiFuh3u5sPgHzh0i3eoaeDK6a72Idc";
            options.SecretKey = "sandbox-r8qKpYEbYpkRnqQ0I49dxXQxJye4scvK";
            options.BaseUrl = "https://sandbox-api.iyzipay.com";

            List<Product> productsFromDb = products;
            
            // Sepet tutarını kendi databaseimizden gelen bilgiden hesaplıyoruz.
            double totalPrice = 0.0;
            
            foreach (CartDetails productDetails in checkoutHeader.CartDetailsList)
            {
                var priceEach = productsFromDb.Find(p => p.ProductId == productDetails.ProductId).Price;
                var count = productDetails.Count;
                totalPrice += priceEach * count;
            }
            totalPrice = Math.Round(totalPrice, 2);
            //CouponDto couponDetails = await _couponRepository.GetCoupon(cartDto.CartHeader.CouponCode);
            //double discountAmount = couponDetails.DiscountAmount;

            CreatePaymentRequest request = new CreatePaymentRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = new Random().Next(1111, 9999).ToString();
            request.Price = totalPrice.ToString(System.Globalization.CultureInfo.InvariantCulture);
            //request.PaidPrice = totalPrice - discountAmount;
            request.PaidPrice = totalPrice.ToString(System.Globalization.CultureInfo.InvariantCulture);


            //request.Price = "15";//checkoutHeaderDto.OrderTotal.ToString();
            //request.PaidPrice = "15";//checkoutHeaderDto.OrderTotal.ToString();
            request.Currency = Currency.TRY.ToString();
            request.Installment = 1;
            request.BasketId = "B67832";
            request.BasketId = checkoutHeader.cartHeader.CartHeaderId.ToString();
            request.PaymentChannel = PaymentChannel.WEB.ToString();
            request.PaymentGroup = PaymentGroup.PRODUCT.ToString();

            PaymentCard paymentCard = new PaymentCard();
            paymentCard.CardHolderName = $"{checkoutHeader.FirstName} {checkoutHeader.LastName}";
            paymentCard.CardNumber = checkoutHeader.CardNumber;
            paymentCard.ExpireMonth = checkoutHeader.ExpiryMonth;
            paymentCard.ExpireYear = checkoutHeader.ExpiryYear;
            paymentCard.Cvc = checkoutHeader.CVV;
            paymentCard.RegisterCard = 0;
            paymentCard.CardAlias = "Inveon";
            request.PaymentCard = paymentCard;

            Buyer buyer = new Buyer();
            //buyer.Id = cartDto.CartHeader.UserId;
            buyer.Id = "BY789";
            buyer.Name = checkoutHeader.FirstName;
            buyer.Surname = checkoutHeader.LastName;
            buyer.GsmNumber = checkoutHeader.Phone;
            buyer.Email = checkoutHeader.Email;
            buyer.IdentityNumber = "74300864791";
            buyer.LastLoginDate = "2015-10-05 12:43:35";
            buyer.RegistrationDate = "2013-04-21 15:12:09";
            buyer.RegistrationAddress = "Inveon Headquarters, Levent Istanbul";
            buyer.Ip = "85.34.78.112";
            buyer.City = "Istanbul";
            buyer.Country = "Turkey";
            buyer.ZipCode = "34732";
            request.Buyer = buyer;

            Address shippingAddress = new Address();
            shippingAddress.ContactName = $"{checkoutHeader.FirstName} {checkoutHeader.LastName}"; ;
            shippingAddress.City = "Istanbul";
            shippingAddress.Country = "Turkey";
            shippingAddress.Description = "Inveon Headquarters, Levent Istanbul";
            shippingAddress.ZipCode = "34742";
            request.ShippingAddress = shippingAddress;

            Address billingAddress = new Address();
            billingAddress.ContactName = $"{checkoutHeader.FirstName} {checkoutHeader.LastName}"; ;
            billingAddress.City = "Istanbul";
            billingAddress.Country = "Turkey";
            billingAddress.Description = "Inveon Headquarters, Levent Istanbul";
            billingAddress.ZipCode = "34742";
            request.BillingAddress = billingAddress;

            List<BasketItem> basketItems = new List<BasketItem>();

            // Sepetteki her ürünü teker teker iyzico'nun sipariş detayları kısmına yazdır.
            foreach (CartDetails productDetails in checkoutHeader.CartDetailsList)
            {
                Product productInfo = productsFromDb.Find(p => p.ProductId == productDetails.ProductId);
                BasketItem basketItem = new BasketItem();
                basketItem.Id = productInfo.ProductId.ToString();
                basketItem.Name = productInfo.Name;
                // basketItem.Category1 = productInfo.CategoryName;
                basketItem.Category1 = productInfo.CategoryID.ToString();
                basketItem.ItemType = BasketItemType.PHYSICAL.ToString();
                basketItem.Price = (productInfo.Price * productDetails.Count).ToString(System.Globalization.CultureInfo.InvariantCulture);
                basketItems.Add(basketItem);
            }

            request.BasketItems = basketItems;

            return Payment.Create(request, options);
        }
    }
}
