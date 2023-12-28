using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Inveon.Models
{
    public class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductId { get; set; }
        [Required]
        public string Name { get; set; }
        public double Price { get; set; }
        public string CurrencyType { get; set; }
        public string Description { get; set; }
        public int CategoryID { get; set; }
        [ForeignKey("CategoryID")]
        public virtual Category Category { get; set; }
        public int BrandID { get; set; }
        [ForeignKey("BrandID")]
        public virtual Brand Brand { get; set; }
        public string Gender { get; set; }
        public string Material { get; set; }
        public string Style { get; set; }
        public string Color { get; set; }
        public string Cut { get; set; }
        public string Season { get; set; }
        public string ImageUrls { get; set; }
        public string DateAdded { get; set; }
        public string CategoryName => Category?.CategoryName; // Assuming 'Name' is the property in the Category class
        public string BrandName => Brand?.Name; // Assuming 'Name' is the property in the Brand class
    }
}
