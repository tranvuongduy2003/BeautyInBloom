namespace BeautyInBloom.Models.DTOs;

public class ReviewDTO
{
    public string Id { get; set; }
    
    public string  UserId { get; set; }
    
    public string ProductId { get; set; }
    
    public string? Content { get; set; }
    
    public float Rating { get; set; }
    
    public DateTime CreatedAt { get; set; }
    
    public DateTime? UpdatedAt { get; set; }
}