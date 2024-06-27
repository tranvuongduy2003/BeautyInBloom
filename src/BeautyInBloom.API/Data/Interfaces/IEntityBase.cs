namespace BeautyInBloom.API.Data.Interfaces;

public interface IEntityBase<T>
{
    T Id { get; set; }
}