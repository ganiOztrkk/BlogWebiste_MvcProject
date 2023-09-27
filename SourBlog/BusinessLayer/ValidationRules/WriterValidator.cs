using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Name Must Be Written.");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Minimum 2 Characters");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Surname Must Be Written.");
            RuleFor(x => x.WriterSurname).MaximumLength(50).WithMessage("Maximum 50 Characters");
            RuleFor(x => x.WriterAbout).MaximumLength(200).WithMessage("Maximum 200 Characters");
        }
    }
}