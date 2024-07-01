﻿namespace BeautyInBloom.Models.DTOs;

public class CategoryDTO
{
    public string Id { get; set; }

    public string Name { get; set; }

    public string? Description { get; set; }
    
    public DateTime CreatedAt { get; set; }
    
    public DateTime? UpdatedAt { get; set; }
}