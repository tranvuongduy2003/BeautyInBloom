namespace BeautyInBloom.Models.DTOs;

public class ProductDTO
{
    public string Id { get; set; }
    
    public string Name { get; set; }
    
    public string? Description { get; set; } = String.Empty;

    public decimal Price { get; set; }
    
    public string BrandId { get; set; }

    public decimal ImportPrice { get; set; }
    
    public string CategoryId { get; set; }

    public int Inventory { get; set; }

    public int? NumberOfSold { get; set; } = 0;
    
    public List<string> Images { get; set; } = new List<string>();
    
    public DateTime CreatedAt { get; set; }
    
    public DateTime? UpdatedAt { get; set; }
}