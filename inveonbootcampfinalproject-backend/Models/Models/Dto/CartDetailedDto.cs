namespace Inveon.Models.DTOs
{
    public class CartDetailedDto
    {
        public CartHeaderDetailedDto CartHeader { get; set; }
        public IEnumerable<CartDetailsDto> CartDetails { get; set; }
    }
}
