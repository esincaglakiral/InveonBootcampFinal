using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Inveon.Models;

public class Brand
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int BrandId { get; set; }
    [Required]
    public string Name { get; set; }
}