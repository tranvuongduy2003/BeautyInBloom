using BeautyInBloom.API.Data;
using BeautyInBloom.API.Data.Entities;
using BeautyInBloom.API.Infrastructure.RepositoryBase;
using BeautyInBloom.API.Repositories.Contracts;

namespace BeautyInBloom.API.Repositories;

public class OrdersRepository : RepositoryBase<Order, string>, IOrdersRepository
{
    public OrdersRepository(ApplicationDbContext dbContext) : base(
        dbContext)
    {
    }
}