using Inveon.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Inveon.Services.Favorites;

public class FavoriteRepository : IFavoriteRepository
{
    private readonly AppDbContext _dbContext;

    public FavoriteRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public void AddFavorite([FromBody] FavoriteProduct favProduct)
    {
        _dbContext.Favorites.Add(favProduct);
        _dbContext.SaveChanges();
    }
    public async Task<bool> DeleteFromFavorites(string userId, int productId)
    {
        FavoriteProduct favProd =
            await _dbContext.Favorites.FirstOrDefaultAsync(p => p.UserId == userId && p.ProductId == productId);
        _dbContext.Favorites.Remove(favProd);
        _dbContext.SaveChanges();
        return true;
    }

    public IEnumerable<FavoriteProduct> GetFavoritesForUser(string userId)
    {
        return _dbContext.Favorites.Where(r => r.UserId == userId).ToList();
    }
}