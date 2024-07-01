using BeautyInBloom.API.Data.EntityBases;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyInBloom.API.Data.Entities;

[Table("Brands")]
public class Brand : EntityAuditBase<string>
{
    [Required]
    [Column(TypeName = "nvarchar(100)")]
    public string Name { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}