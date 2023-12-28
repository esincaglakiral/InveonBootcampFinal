using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inveon.Models;
public class ProductStock
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ProductStockId { get; set; }

    public int ProductId { get; set; }

    [Required]
    [MaxLength(10)] // Adjust the maximum length as needed
    public string Size { get; set; }

    [Range(0, int.MaxValue)]
    public int StockQuantity { get; set; }
    
}