using BeautyInBloom.API.Data;
using BeautyInBloom.API.Data.Entities;
using BeautyInBloom.API.Infrastructure.RepositoryBase;
using BeautyInBloom.API.Repositories.Contracts;

namespace BeautyInBloom.API.Repositories;

public class BrandsRepository : RepositoryBase<Brand, string>, IBrandsRepository
{
    public BrandsRepository(ApplicationDbContext dbContext) : base(
        dbContext)
    {
    }
}