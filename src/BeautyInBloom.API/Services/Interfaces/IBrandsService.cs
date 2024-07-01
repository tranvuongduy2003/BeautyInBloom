using BeautyInBloom.Models.DTOs;
using BeautyInBloom.Models.Requests;

namespace BeautyInBloom.API.Services.Interfaces;

public interface IBrandsService
{
    Task<List<BrandDTO>> FindAllBrands();

    Task<BrandDTO> CreateBrand(CreateBrandRequest request);
}