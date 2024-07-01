using BeautyInBloom.API.Services.Interfaces;
using BeautyInBloom.Models.DTOs;
using BeautyInBloom.Models.Requests;

namespace BeautyInBloom.API.Services;

public class CategoriesService : ICategoriesService
{
    public async Task<List<CategoryDTO>> FindAllCategories()
    {
        throw new NotImplementedException();
    }

    public async Task<CategoryDTO> CreateCategory(CreateCategoryRequest request)
    {
        throw new NotImplementedException();
    }
}