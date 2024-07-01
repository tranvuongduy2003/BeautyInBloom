namespace BeautyInBloom.Models.Requests;

public class CreateProductRequest
{
    public string Name { get; set; }
    
    public string? Description { get; set; }

    public decimal Price { get; set; }
    
    public string BrandId { get; set; }

    public decimal ImportPrice { get; set; }
    
    public string CategoryId { get; set; }

    public int Inventory { get; set; }
    
    public List<string> Images { get; set; }
}