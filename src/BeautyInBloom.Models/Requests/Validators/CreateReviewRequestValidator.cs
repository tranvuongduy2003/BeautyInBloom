using FluentValidation;

namespace BeautyInBloom.Models.Requests.Validators;

public class CreateReviewRequestValidator : AbstractValidator<CreateReviewRequest>
{
    public CreateReviewRequestValidator()
    {
        RuleFor(x => x.ProductId)
            .NotEmpty().WithMessage("ProductId is required")
            .MaximumLength(50).WithMessage("ProductId must be less than 50 characters");
        
        RuleFor(x => x.UserId)
            .NotEmpty().WithMessage("UserId is required")
            .MaximumLength(50).WithMessage("UserId must be less than 50 characters");
        
        RuleFor(x => x.Rating)
            .NotEmpty().WithMessage("Rating is required")
            .ExclusiveBetween((float)0.0, (float)5.0).WithMessage("Rating must be between 0.0 and 5.0");
    }
}