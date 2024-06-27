using BeautyInBloom.API.Data.Entities;
using System.Security.Claims;

namespace BeautyInBloom.API.Services.Interfaces;

public interface ITokenService
{
    Task<string> GenerateAccessTokenAsync(User user);
    string GenerateRefreshToken();
    ClaimsPrincipal? GetPrincipalFromToken(string token);
    bool ValidateTokenExpire(string token);
}