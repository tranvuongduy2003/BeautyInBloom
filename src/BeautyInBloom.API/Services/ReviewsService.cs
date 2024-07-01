using BeautyInBloom.API.Services.Interfaces;
using BeautyInBloom.Models.DTOs;
using BeautyInBloom.Models.Requests;

namespace BeautyInBloom.API.Services;

public class ReviewsService : IReviewsService
{
    public async Task<List<ReviewDTO>> FindAllReviews()
    {
        throw new NotImplementedException();
    }

    public async Task<List<ReviewDTO>> FindAllReviewsByProductId(string productId)
    {
        throw new NotImplementedException();
    }

    public async Task<ReviewDTO> CreateReview(CreateReviewRequest request)
    {
        throw new NotImplementedException();
    }

    public async Task<ReviewDTO> UpdateReview(string reviewId, UpdateReviewRequest request)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> DeleteReview(string reviewId)
    {
        throw new NotImplementedException();
    }
}