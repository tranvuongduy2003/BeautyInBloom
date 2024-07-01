using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BeautyInBloom.API.Data.Interfaces;

namespace BeautyInBloom.API.Data.EntityBases;

public abstract class EntityBase<TKey> : IEntityBase<TKey>
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [MaxLength(50)]
    [Column(TypeName = "varchar(50)")]
    public TKey Id { get; set; }
}