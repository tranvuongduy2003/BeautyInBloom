using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BeautyInBloom.Models.Enums;

namespace BeautyInBloom.Models.Requests;

public class CreateOrderRequest
{
    public EOrderStatus Status { get; set; }
    
    public string UserId { get; set; }

    public string ReceiptAddress { get; set; }

    public string ReceiptName { get; set; }

    public string ReceiptPhone { get; set; }

    public List<ProductItem> Products  { get; set; }
}

public class ProductItem
{
    public string ProductId { get; set; }

    public int Quantity { get; set; }
}