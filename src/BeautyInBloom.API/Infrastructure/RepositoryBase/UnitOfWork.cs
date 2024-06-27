using BeautyInBloom.API.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BeautyInBloom.API.Infrastructure.RepositoryBase;

public class UnitOfWork<TContext> : IUnitOfWork<TContext> where TContext : DbContext
{
    private readonly TContext _context;

    public UnitOfWork(TContext context)
    {
        _context = context;
    }

    public void Dispose() => _context.Dispose();

    public Task<int> CommitAsync() => _context.SaveChangesAsync();
}