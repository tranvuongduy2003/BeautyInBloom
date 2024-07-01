using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BeautyInBloom.API.Data.EntityBases;

namespace BeautyInBloom.API.Data.Entities;

[Table("OrderItems")]
public class OrderItem : EntityAuditBase<string>
{
    [Required] 
    public int Quantity { get; set; } = 0;

    [Required] 
    [MaxLength(50)] 
    public string ProductId { get; set; }

    [Required] 
    [MaxLength(50)]
    public string OrderId { get; set; }

    [Required]
    public decimal SumPrice { get; set; }

    [ForeignKey("ProductId")]
    public virtual Product Product { get; set; }

    [ForeignKey("OrderId")]
    public virtual Order Order { get; set; }
}