using BeautyInBloom.API.Data.EntityBases;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyInBloom.API.Data.Entities;

[Table("Products")]
public class Product : EntityAuditBase<string>
{
    [Required]
    [Column(TypeName = "nvarchar(100)")]
    public string Name { get; set; }

    [Column(TypeName = "nvarchar(max)")]
    public string? Description { get; set; } = String.Empty;

    public decimal Price { get; set; }

    [Required]
    [MaxLength(50)]
    [Column(TypeName = "varchar(50)")]
    public string BrandId { get; set; }

    public decimal ImportPrice { get; set; }

    [Required]
    [MaxLength(50)]
    [Column(TypeName = "varchar(50)")]
    public string CategoryId { get; set; }

    public int Inventory { get; set; }

    public int? NumberOfSold { get; set; } = 0;

    [Column(TypeName = "jsonb")]
    public List<string> Images { get; set; } = new List<string>();

    [ForeignKey("BrandId")]
    public virtual Brand Brand { get; set; }

    [ForeignKey("CategoryId")]
    public virtual Category Category { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}