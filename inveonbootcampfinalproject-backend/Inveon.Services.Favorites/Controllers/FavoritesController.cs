using System.Security.Claims;
using Inveon.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Inveon.Services.Favorites.Controllers;

[ApiController]
[Route("api/")]
public class ReviewController : ControllerBase
{
    private readonly FavoriteRepository _favoriteRepository;

    public ReviewController(FavoriteRepository favoriteRepository)
    {
        _favoriteRepository = favoriteRepository;
    }

    [Authorize]
    [HttpPost("addFavorite")]
    public IActionResult AddFavorite([FromBody] FavoriteProductDto favProductDto)
    {
        ClaimsPrincipal currentUser = this.User;
        string userId = currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;
        
        FavoriteProduct fa = new FavoriteProduct();
        fa.ProductId = favProductDto.ProductId;
        fa.UserId = userId;
        fa.Timestamp = DateTime.UtcNow;
        
        try
        {
            _favoriteRepository.AddFavorite(fa);
            return Ok(favProductDto);
        }
        catch (InvalidOperationException ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [Authorize]
    [HttpGet("getFavorites")]
    public IActionResult GetFavorites()
    {
        ClaimsPrincipal currentUser = this.User;
        string userId = currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;
        var reviews = _favoriteRepository.GetFavoritesForUser(userId);
        return Ok(reviews);
    }
    
    [Authorize]
    [HttpDelete("deleteFromFavorites")]
    public async Task<object> DeleteFromFavorites([FromBody] FavoriteProductDto favProductDto)
    {
        ClaimsPrincipal currentUser = this.User;
        string userId = currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;

        try
        {
            bool success = await _favoriteRepository.DeleteFromFavorites(userId, favProductDto.ProductId);
        }
        catch
        {
            return BadRequest();
        }
        return Ok();
    }
}