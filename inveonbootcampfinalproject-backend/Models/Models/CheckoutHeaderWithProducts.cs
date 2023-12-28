using Inveon.MessageBus;

namespace Inveon.Models
{
    public class CheckoutHeaderWithProducts : BaseMessage
    {
        public string UserId { get; set; }
        public double OrderTotal { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string CardNumber { get; set; }
        public string CVV { get; set; }
        public string ExpiryMonth { get; set; }
        public string ExpiryYear { get; set; }
        public CartHeader cartHeader { get; set; }
        public IEnumerable<CartDetails> CartDetailsList { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
