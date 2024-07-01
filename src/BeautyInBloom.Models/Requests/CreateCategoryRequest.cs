namespace BeautyInBloom.Models.Requests;

public class CreateCategoryRequest
{
    public string Name { get; set; }
    
    public string? Description { get; set; }
}