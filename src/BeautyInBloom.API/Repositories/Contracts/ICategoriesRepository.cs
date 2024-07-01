using BeautyInBloom.API.Data.Entities;
using BeautyInBloom.API.Infrastructure.Interfaces;

namespace BeautyInBloom.API.Repositories.Contracts;

public interface ICategoriesRepository: IRepositoryBase<Category, string>
{
}