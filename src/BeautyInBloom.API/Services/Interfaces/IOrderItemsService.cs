using BeautyInBloom.Models.DTOs;
using BeautyInBloom.Models.Requests;

namespace BeautyInBloom.API.Services.Interfaces;

public interface IOrderItemsService
{
    Task<List<OrderItemDTO>> FindAllOrderItems();

    Task<OrderItemDTO> FindOrderItemById(string orderItemId);

    Task<OrderItemDTO> CreateOrderItem(CreateOrderItemRequest request);
    
    Task<OrderItemDTO> UpdateOrderItem(string orderItemId, CreateOrderItemRequest request);

    Task<bool> DeleteOrderItem(string orderItemId);
}