using BeautyInBloom.API.Data.Interfaces;

namespace BeautyInBloom.API.Data.EntityBases;

public class EntityAuditBase<TKey> : EntityBase<TKey>, IDateTracking
{
    public DateTime CreatedAt { get; set; }
    
    public DateTime? UpdatedAt { get; set; }
}