using BeautyInBloom.API.Services.Interfaces;
using BeautyInBloom.Models.DTOs;
using BeautyInBloom.Models.Requests;

namespace BeautyInBloom.API.Services;

public class BrandsService : IBrandsService
{
    public async Task<List<BrandDTO>> FindAllBrands()
    {
        throw new NotImplementedException();
    }

    public async Task<BrandDTO> CreateBrand(CreateBrandRequest request)
    {
        throw new NotImplementedException();
    }
}