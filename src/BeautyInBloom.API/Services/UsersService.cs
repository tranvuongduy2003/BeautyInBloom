using BeautyInBloom.API.Services.Interfaces;
using BeautyInBloom.Models.DTOs;
using BeautyInBloom.Models.Requests;

namespace BeautyInBloom.API.Services;

public class UsersService : IUsersService
{
    public async Task<List<UserDTO>> FindAllUsers()
    {
        throw new NotImplementedException();
    }

    public async Task<UserDTO> FindUserById(string userId)
    {
        throw new NotImplementedException();
    }

    public async Task<UserDTO> CreateUser(CreateUserRequest request)
    {
        throw new NotImplementedException();
    }

    public async Task<UserDTO> UpdateUser(string userId, CreateUserRequest request)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> DeleteUser(string userId)
    {
        throw new NotImplementedException();
    }

    public async Task<UserDTO> UpdateUserPassword(string userId, UpdatePasswordRequest request)
    {
        throw new NotImplementedException();
    }

    public async Task<UserDTO> UpdateUserStatus(string userId, bool isActive)
    {
        throw new NotImplementedException();
    }
}