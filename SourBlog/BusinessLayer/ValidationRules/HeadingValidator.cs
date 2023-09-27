using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class HeadingValidator : AbstractValidator<Heading>
    {
        public HeadingValidator()
        {
            RuleFor(x => x.HeadingName).NotEmpty().WithMessage("Name must be written.");
            RuleFor(x => x.HeadingName).MaximumLength(70).WithMessage("Maximum 70 Character.");
        }
    }
}