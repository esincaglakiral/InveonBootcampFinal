using Inveon.Models;
namespace Inveon.Services.Reviews;

public interface IReviewRepository
{
    void AddReview(Review review);
    IEnumerable<Review> GetReviewsForProduct(int productId);

}