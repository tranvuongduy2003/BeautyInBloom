using BeautyInBloom.Models.DTOs;
using BeautyInBloom.Models.Requests;

namespace BeautyInBloom.API.Services.Interfaces;

public interface IReviewsService
{
    Task<List<ReviewDTO>> FindAllReviews();
    
    Task<List<ReviewDTO>> FindAllReviewsByProductId(string productId);

    Task<ReviewDTO> CreateReview(CreateReviewRequest request);

    Task<ReviewDTO> UpdateReview(string reviewId, UpdateReviewRequest request);

    Task<bool> DeleteReview(string reviewId);
}