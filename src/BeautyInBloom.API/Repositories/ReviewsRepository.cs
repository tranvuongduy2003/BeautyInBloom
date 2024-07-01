using BeautyInBloom.API.Data;
using BeautyInBloom.API.Data.Entities;
using BeautyInBloom.API.Infrastructure.RepositoryBase;
using BeautyInBloom.API.Repositories.Contracts;

namespace BeautyInBloom.API.Repositories;

public class ReviewsRepository : RepositoryBase<Review, string>, IReviewsRepository
{
    public ReviewsRepository(ApplicationDbContext dbContext) : base(
        dbContext)
    {
    }
}