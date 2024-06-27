using Microsoft.EntityFrameworkCore;

namespace BeautyInBloom.API.Infrastructure.Interfaces;

public interface IUnitOfWork<TContext> : IDisposable where TContext : DbContext
{
    Task<int> CommitAsync();
}