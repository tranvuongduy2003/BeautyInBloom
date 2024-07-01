using BeautyInBloom.Models.DTOs;
using BeautyInBloom.Models.Requests;

namespace BeautyInBloom.API.Services.Interfaces;

public interface IOrdersService
{
    Task<bool> IsOrderBelongsToUser(string orderId, string userId);

    Task<List<OrderDTO>> FindAllOrders();

    Task<List<OrderDTO>> FindAllOrdersByUserId(string userId);

    Task<OrderDTO> FindOrderById(string orderId);

    Task<OrderDTO> CreateOrder(CreateOrderRequest request);

    Task<OrderDTO> UpdateOrder(UpdateOrderRequest request);

    Task<bool> DeleteOrder(string orderId);
}