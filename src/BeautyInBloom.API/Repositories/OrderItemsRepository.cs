using BeautyInBloom.API.Data;
using BeautyInBloom.API.Data.Entities;
using BeautyInBloom.API.Infrastructure.RepositoryBase;
using BeautyInBloom.API.Repositories.Contracts;

namespace BeautyInBloom.API.Repositories;

public class OrderItemsRepository : RepositoryBase<OrderItem, string>, IOrderItemsRepository
{
    public OrderItemsRepository(ApplicationDbContext dbContext) : base(
        dbContext)
    {
    }
}