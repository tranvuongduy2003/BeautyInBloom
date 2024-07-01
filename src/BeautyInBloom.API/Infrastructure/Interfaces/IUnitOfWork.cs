namespace BeautyInBloom.API.Infrastructure.Interfaces;

public interface IUnitOfWork : IDisposable
{
    Task<int> CommitAsync();
}