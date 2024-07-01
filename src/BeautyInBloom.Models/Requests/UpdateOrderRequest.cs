using BeautyInBloom.Models.Enums;

namespace BeautyInBloom.Models.Requests;

public class UpdateOrderRequest
{
    public EOrderStatus Status { get; set; }
    
    public string UserId { get; set; }

    public string ReceiptAddress { get; set; }

    public string ReceiptName { get; set; }

    public string ReceiptPhone { get; set; }
}