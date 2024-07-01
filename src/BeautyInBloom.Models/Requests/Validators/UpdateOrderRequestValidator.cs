using FluentValidation;

namespace BeautyInBloom.Models.Requests.Validators;

public class UpdateOrderRequestValidator : AbstractValidator<UpdateOrderRequest>
{
    public UpdateOrderRequestValidator()
    {
        RuleFor(x => x.UserId)
            .NotEmpty().WithMessage("UserId is required")
            .MaximumLength(50).WithMessage("UserId must be less than 50 characters");

        RuleFor(x => x.Status)
            .NotEmpty().WithMessage("Status is required")
            .IsInEnum().WithMessage("Status is not allowed value");

        RuleFor(x => x.ReceiptAddress)
            .NotEmpty().WithMessage("ReceiptAddress is required");

        RuleFor(x => x.ReceiptName)
            .NotEmpty().WithMessage("ReceiptName is required")
            .MaximumLength(50).WithMessage("ReceiptName must be less than 50 characters");

        RuleFor(x => x.ReceiptPhone)
            .NotEmpty().WithMessage("ReceiptPhone is required")
            .MaximumLength(20).WithMessage("ReceiptPhone must be less than 20 characters");
    }
}