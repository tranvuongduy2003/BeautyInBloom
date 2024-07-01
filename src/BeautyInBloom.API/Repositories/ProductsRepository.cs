using BeautyInBloom.API.Data;
using BeautyInBloom.API.Data.Entities;
using BeautyInBloom.API.Infrastructure.RepositoryBase;
using BeautyInBloom.API.Repositories.Contracts;

namespace BeautyInBloom.API.Repositories;

public class ProductsRepository : RepositoryBase<Product, string>, IProductsRepository
{
    public ProductsRepository(ApplicationDbContext dbContext) : base(
        dbContext)
    {
    }
}