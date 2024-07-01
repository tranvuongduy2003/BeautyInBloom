using BeautyInBloom.API.Services.Interfaces;
using BeautyInBloom.Models.DTOs;
using BeautyInBloom.Models.Requests;

namespace BeautyInBloom.API.Services;

public class OrdersService : IOrdersService 
{
    public async Task<bool> IsOrderBelongsToUser(string orderId, string userId)
    {
        throw new NotImplementedException();
    }

    public async Task<List<OrderDTO>> FindAllOrders()
    {
        throw new NotImplementedException();
    }

    public async Task<List<OrderDTO>> FindAllOrdersByUserId(string userId)
    {
        throw new NotImplementedException();
    }

    public async Task<OrderDTO> FindOrderById(string orderId)
    {
        throw new NotImplementedException();
    }

    public async Task<OrderDTO> CreateOrder(CreateOrderRequest request)
    {
        throw new NotImplementedException();
    }

    public async Task<OrderDTO> UpdateOrder(UpdateOrderRequest request)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> DeleteOrder(string orderId)
    {
        throw new NotImplementedException();
    }
}