using BeautyInBloom.Models.DTOs;
using BeautyInBloom.Models.Requests;

namespace BeautyInBloom.API.Services.Interfaces;

public interface ICategoriesService
{
    Task<List<CategoryDTO>> FindAllCategories();

    Task<CategoryDTO> CreateCategory(CreateCategoryRequest request);
}