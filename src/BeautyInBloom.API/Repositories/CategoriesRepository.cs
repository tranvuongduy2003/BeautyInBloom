using BeautyInBloom.API.Data;
using BeautyInBloom.API.Data.Entities;
using BeautyInBloom.API.Infrastructure.RepositoryBase;
using BeautyInBloom.API.Repositories.Contracts;

namespace BeautyInBloom.API.Repositories;

public class CategoriesRepository : RepositoryBase<Category, string>, ICategoriesRepository
{
    public CategoriesRepository(ApplicationDbContext dbContext) : base(
        dbContext)
    {
    }
}