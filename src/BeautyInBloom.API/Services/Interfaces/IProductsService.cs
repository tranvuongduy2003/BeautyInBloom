using BeautyInBloom.Models.DTOs;
using BeautyInBloom.Models.Requests;

namespace BeautyInBloom.API.Services.Interfaces;

public interface IProductsService
{
    Task<List<ProductDTO>> FindAllProducts();

    Task<ProductDTO> FindProductById(string productId);

    Task<ProductDTO> CreateProduct(CreateProductRequest request);

    Task<ProductDTO> UpdateProduct(string productId, CreateProductRequest request);

    Task<bool> DeleteProduct(string productId);
}