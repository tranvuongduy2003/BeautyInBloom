using BeautyInBloom.API.Data.Interfaces;

namespace BeautyInBloom.API.Data.EntityBases;

public class EntityAuditBase<T> : EntityBase<T>, IDateTracking
{
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}