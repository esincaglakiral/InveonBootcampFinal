namespace Inveon.Models.DTOs
{
    public class ProductDto
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string CurrencyType { get; set; }
        public string Description { get; set; }
        public int CategoryID { get; set; }
        public int BrandID { get; set; }
        public string BrandName { get; set; }
        public string CategoryName { get; set; }
        public string Gender { get; set; }
        public string Material { get; set; }
        public string Style { get; set; }
        public string Color { get; set; }
        public string Cut { get; set; }
        public string Season { get; set; }
        public string ImageUrls { get; set; }
        public string DateAdded { get; set; }
        public int? Count { get; set; }
    }
}
