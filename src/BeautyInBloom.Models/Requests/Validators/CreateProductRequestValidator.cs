using FluentValidation;
using FluentValidation.Validators;

namespace BeautyInBloom.Models.Requests.Validators;

public class CreateProductRequestValidator : AbstractValidator<CreateProductRequest>
{
    public CreateProductRequestValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Name is required")
            .MaximumLength(100).WithMessage("Name must be less than 100 characters");
        
        RuleFor(x => x.Description)
            .NotEmpty().WithMessage("Description is required");
        
        RuleFor(x => x.Inventory)
            .NotEmpty().WithMessage("Inventory is required")
            .GreaterThan(0).WithMessage("Inventory must be greater than 0");
        
        RuleFor(x => x.BrandId)
            .NotEmpty().WithMessage("BrandId is required")
            .MaximumLength(50).WithMessage("BrandId must be less than 50 characters");
        
        RuleFor(x => x.CategoryId)
            .NotEmpty().WithMessage("CategoryId is required")
            .MaximumLength(50).WithMessage("CategoryId must be less than 50 characters");
        
        RuleFor(x => x.Price)
            .NotEmpty().WithMessage("Price is required")
            .GreaterThan(0).WithMessage("Price must be greater than 0");
        
        RuleFor(x => x.ImportPrice)
            .NotEmpty().WithMessage("ImportPrice is required")
            .GreaterThan(0).WithMessage("ImportPrice must be greater than 0");
        
        RuleFor(x => x.Images)
            .NotEmpty().WithMessage("Images is required");
    }
}