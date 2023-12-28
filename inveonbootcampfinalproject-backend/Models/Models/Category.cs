using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Inveon.Models
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryID { get; set; }

        [Required] 
        [MaxLength(50)] 
        public string CategoryName { get; set; }

        // Navigation property to establish a relationship with the Product table
        public virtual ICollection<Product> Products { get; set; }
    }
}