using BeautyInBloom.API.Services.Interfaces;
using BeautyInBloom.Models.DTOs;
using BeautyInBloom.Models.Requests;

namespace BeautyInBloom.API.Services;

public class ProductsService : IProductsService
{
    public async Task<List<ProductDTO>> FindAllProducts()
    {
        throw new NotImplementedException();
    }

    public async Task<ProductDTO> FindProductById(string productId)
    {
        throw new NotImplementedException();
    }

    public async Task<ProductDTO> CreateProduct(CreateProductRequest request)
    {
        throw new NotImplementedException();
    }

    public async Task<ProductDTO> UpdateProduct(string productId, CreateProductRequest request)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> DeleteProduct(string productId)
    {
        throw new NotImplementedException();
    }
}