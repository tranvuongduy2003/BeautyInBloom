using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BeautyInBloom.API.Data.EntityBases;

namespace BeautyInBloom.API.Data.Entities;

[Table("Commands")]
public class Command : EntityBase<string>
{
    [Required]
    [MaxLength(50)]
    [Column(TypeName = "nvarchar(50)")]
    public string Name { get; set; }

    public virtual ICollection<CommandInFunction> CommandInFunctions { get; set; } = new List<CommandInFunction>();

    public virtual ICollection<Permission> Permissions { get; set; } = new List<Permission>();
}