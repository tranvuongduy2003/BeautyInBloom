using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using BeautyInBloom.API.Data.EntityBases;
using BeautyInBloom.Models.Enums;

namespace BeautyInBloom.API.Data.Entities;

[Table("Orders")]
public class Order : EntityAuditBase<string>
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public EOrderStatus Status { get; set; }

    [Required]
    [MaxLength(50)]
    public string UserId { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(max)")]
    public string ReceiptAddress { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(50)")]
    public string ReceiptName { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(20)")]
    public string ReceiptPhone { get; set; }

    [ForeignKey("UserId")]
    public virtual User User { get; set; }
    
    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}