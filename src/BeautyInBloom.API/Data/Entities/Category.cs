using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BeautyInBloom.API.Data.EntityBases;

namespace BeautyInBloom.API.Data.Entities;

[Table("Categories")]
public class Category : EntityAuditBase<string>
{
    [Required]
    [Column(TypeName = "nvarchar(100)")]
    public string Name { get; set; }
    
    [Column(TypeName = "nvarchar(max)")]
    public string? Description { get; set; } = String.Empty;
    
    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}