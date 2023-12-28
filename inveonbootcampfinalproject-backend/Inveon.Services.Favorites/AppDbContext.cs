using Inveon.Models;
using Microsoft.EntityFrameworkCore;

namespace Inveon.Services.Favorites;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<FavoriteProduct> Favorites { get; set; }
}