using BeautyInBloom.API.Services.Interfaces;
using BeautyInBloom.Models.DTOs;
using BeautyInBloom.Models.Requests;

namespace BeautyInBloom.API.Services;

public class OrderItemsService : IOrderItemsService
{
    public async Task<List<OrderItemDTO>> FindAllOrderItems()
    {
        throw new NotImplementedException();
    }

    public async Task<OrderItemDTO> FindOrderItemById(string orderItemId)
    {
        throw new NotImplementedException();
    }

    public async Task<OrderItemDTO> CreateOrderItem(CreateOrderItemRequest request)
    {
        throw new NotImplementedException();
    }

    public async Task<OrderItemDTO> UpdateOrderItem(string orderItemId, CreateOrderItemRequest request)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> DeleteOrderItem(string orderItemId)
    {
        throw new NotImplementedException();
    }
}