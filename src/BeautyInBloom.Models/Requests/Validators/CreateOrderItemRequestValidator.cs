using FluentValidation;

namespace BeautyInBloom.Models.Requests.Validators;

public class CreateOrderItemRequestValidator : AbstractValidator<CreateOrderItemRequest>
{
    public CreateOrderItemRequestValidator()
    {
        RuleFor(x => x.ProductId)
            .NotEmpty().WithMessage("ProductId is required")
            .MaximumLength(50).WithMessage("ProductId must be less than 50 characters");
        
        RuleFor(x => x.OrderId)
            .NotEmpty().WithMessage("OrderId is required")
            .MaximumLength(50).WithMessage("OrderId must be less than 50 characters");
        
        RuleFor(x => x.Quantity)
            .NotEmpty().WithMessage("Quantity is required")
            .GreaterThan(0).WithMessage("Quantity must be greater than 0");
    }
}