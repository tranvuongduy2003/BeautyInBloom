namespace BeautyInBloom.Models.DTOs;

public class OrderItemDTO
{
    public int Quantity { get; set; } = 0;
    
    public string ProductId { get; set; }
    
    public string OrderId { get; set; }
    
    public decimal SumPrice { get; set; }
    
    public DateTime CreatedAt { get; set; }
    
    public DateTime? UpdatedAt { get; set; }
}