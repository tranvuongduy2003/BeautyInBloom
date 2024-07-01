using BeautyInBloom.Models.DTOs;
using BeautyInBloom.Models.Requests;

namespace BeautyInBloom.API.Services.Interfaces;

public interface IUsersService
{
    Task<List<UserDTO>> FindAllUsers();

    Task<UserDTO> FindUserById(string userId);

    Task<UserDTO> CreateUser(CreateUserRequest request);

    Task<UserDTO> UpdateUser(string userId, CreateUserRequest request);

    Task<bool> DeleteUser(string userId);
    
    Task<UserDTO> UpdateUserPassword(string userId, UpdatePasswordRequest request);
    
    Task<UserDTO> UpdateUserStatus(string userId, bool isActive);
}