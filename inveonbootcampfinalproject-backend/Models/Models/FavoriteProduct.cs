namespace Inveon.Models;

public class FavoriteProduct
{
    public int Id { get; set; }
    public string UserId { get; set; }
    public int ProductId { get; set; }
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
}