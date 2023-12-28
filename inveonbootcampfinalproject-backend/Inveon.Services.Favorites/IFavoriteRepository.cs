using Inveon.Models;
namespace Inveon.Services.Favorites;

public interface IFavoriteRepository
{
    void AddFavorite(FavoriteProduct favProduct);
    IEnumerable<FavoriteProduct> GetFavoritesForUser(string userId);

}