namespace BeautyInBloom.API.Data.Interfaces;

public interface IEntityBase<TKey>
{
    TKey Id { get; set; }
}