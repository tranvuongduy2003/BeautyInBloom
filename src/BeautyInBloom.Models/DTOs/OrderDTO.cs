using BeautyInBloom.Models.Enums;

namespace BeautyInBloom.Models.DTOs;

public class OrderDTO
{
    public string Id { get; set; }
    
    public EOrderStatus Status { get; set; }
    
    public string UserId { get; set; }
    
    public string ReceiptAddress { get; set; }
    
    public string ReceiptName { get; set; }
    
    public string ReceiptPhone { get; set; }
    
    public DateTime CreatedAt { get; set; }
    
    public DateTime? UpdatedAt { get; set; }
}