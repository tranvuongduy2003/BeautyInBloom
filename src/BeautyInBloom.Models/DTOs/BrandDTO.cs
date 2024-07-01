﻿namespace BeautyInBloom.Models.DTOs;

public class BrandDTO
{
    public string Id { get; set; }
    
    public string Name { get; set; }

    public DateTime CreatedAt { get; set; }
    
    public DateTime? UpdatedAt { get; set; }
}