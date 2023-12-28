using Inveon.Models;
using Microsoft.EntityFrameworkCore;

namespace Inveon.Services.Reviews;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Review> Reviews { get; set; }
}