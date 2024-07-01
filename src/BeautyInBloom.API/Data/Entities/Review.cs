using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BeautyInBloom.API.Data.EntityBases;

namespace BeautyInBloom.API.Data.Entities;

[Table("Reviews")]
public class Review : EntityAuditBase<string>
{
    [Required]
    [MaxLength(50)]
    public string  UserId { get; set; }

    [Required]
    [MaxLength(50)]
    public string ProductId { get; set; }
    
    [Column(TypeName = "nvarchar(max)")]
    public string? Content { get; set; } = string.Empty;

    [Range(0.0, 5.0)] 
    public float Rating { get; set; } = 0;
    
    [ForeignKey("UserId")]
    public virtual User User { get; set; }
    
    [ForeignKey("ProductId")]
    public virtual Product Product { get; set; }
}