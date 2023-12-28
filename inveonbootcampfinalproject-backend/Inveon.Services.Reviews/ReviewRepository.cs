using Inveon.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Inveon.Services.Reviews;

public class ReviewRepository : IReviewRepository
{
    private readonly AppDbContext _dbContext;

    public ReviewRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public void AddReview([FromBody] Review review)
    {
        _dbContext.Reviews.Add(review);
        _dbContext.SaveChanges();
    }

    public IEnumerable<Review> GetReviewsForProduct(int productId)
    {
        return _dbContext.Reviews.Where(r => r.ProductId == productId).ToList();
    }
}