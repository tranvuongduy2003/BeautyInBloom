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
    public IBrandsRepository Brands { get; private set; }
    public ICategoriesRepository Categories { get; private set; }
    public IOrderItemsRepository OrderItems { get; private set; }
    public IOrdersRepository Orders { get; private set; }
    public IProductsRepository Products { get; private set; }
    public IReviewsRepository Reviews { get; private set; }

    public UnitOfWork(ApplicationDbContext context)
    {
        _context = context;
        Functions = new FunctionsRepository(_context);
        Commands = new CommandsRepository(_context);
        Brands = new BrandsRepository(_context);
        Categories = new CategoriesRepository(_context);
        OrderItems = new OrderItemsRepository(_context);
        Orders = new OrdersRepository(_context);
        Products = new ProductsRepository(_context);
        Reviews = new ReviewsRepository(_context);
    }

    public void Dispose() => _context.Dispose();

    public Task<int> CommitAsync() => _context.SaveChangesAsync();
}