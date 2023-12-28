namespace Inveon.Models;

public class Review
{
    public string UserId { get; set; }
    public string UserName { get; set; }
    public int Id { get; set; }
    public string Comment { get; set; }
    public int Rating { get; set; }
    
    // Foreign key for the product
    public int ProductId { get; set; }
    public DateTime Timestamp { get; set; } 
}