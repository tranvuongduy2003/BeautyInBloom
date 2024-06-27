using BeautyInBloom.API.Data.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyInBloom.API.Data.EntityBases;

public abstract class EntityBase<TKey> : IEntityBase<TKey>
{
    [Key]
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public TKey Id { get; set; }
}