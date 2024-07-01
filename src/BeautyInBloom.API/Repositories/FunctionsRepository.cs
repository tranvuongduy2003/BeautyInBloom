using BeautyInBloom.API.Data;
using BeautyInBloom.API.Data.Entities;
using BeautyInBloom.API.Infrastructure.RepositoryBase;
using BeautyInBloom.API.Repositories.Contracts;

namespace BeautyInBloom.API.Repositories;

public class FunctionsRepository : RepositoryBase<Function, string>, IFunctionsRepository
{
    public FunctionsRepository(ApplicationDbContext dbContext) : base(
        dbContext)
    {
    }
}