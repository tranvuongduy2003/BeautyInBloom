using FluentValidation;

namespace BeautyInBloom.Models.Requests;

public class CreateReviewRequest
{
    public string  UserId { get; set; }
    
    public string ProductId { get; set; }
    
    public string? Content { get; set; }
    
    public float Rating { get; set; }
}