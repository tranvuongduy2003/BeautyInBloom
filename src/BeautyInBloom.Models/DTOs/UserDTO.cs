using BeautyInBloom.Models.Enums;

namespace BeautyInBloom.Models.DTOs;

public class UserDTO
{
    public string Id { get; set; }
    
    public string? FullName { get; set; }

    public string UserName { get; set; }

    public string PhoneNumber { get; set; }

    public string Email { get; set; }

    public DateTime? Dob { get; set; }
    
    public EGender? Gender { get; set; }
    
    public string? Bio { get; set; }

    public string? Avatar { get; set; }
    
    public EUserStatus Status { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}