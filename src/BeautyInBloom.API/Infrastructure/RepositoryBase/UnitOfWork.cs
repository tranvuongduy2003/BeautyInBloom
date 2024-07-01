using BeautyInBloom.API.Data;
using BeautyInBloom.API.Infrastructure.Interfaces;
using BeautyInBloom.API.Repositories;
using BeautyInBloom.API.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace BeautyInBloom.API.Infrastructure.RepositoryBase;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _context;

    public IFunctionsRepository Functions { get; private set; }
    public ICommandsRepository Commands { get; private set; }

    public UnitOfWork(ApplicationDbContext context)
    {
        _context = context;
        Functions = new FunctionsRepository(_context);
        Commands = new CommandsRepository(_context);
    }

    public void Dispose() => _context.Dispose();

    public Task<int> CommitAsync() => _context.SaveChangesAsync();
}