namespace BeautyInBloom.Models.Requests;

public class CreateOrderItemRequest
{
    public string ProductId { get; set; }

    public string OrderId { get; set; }

    public int Quantity { get; set; }
}