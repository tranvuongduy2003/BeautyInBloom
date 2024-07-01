using FluentValidation;

namespace BeautyInBloom.Models.Requests.Validators;

public class UpdateReviewRequestValidator : AbstractValidator<UpdateReviewRequest>
{
    public UpdateReviewRequestValidator()
    {
        RuleFor(x => x.Rating)
            .NotEmpty().WithMessage("Rating is required")
            .ExclusiveBetween((float)0.0, (float)5.0).WithMessage("Rating must be between 0.0 and 5.0");
    }
}