using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x=>x.UserMail).NotEmpty().WithMessage("Enter your mail.");
            RuleFor(x=>x.UserName).NotEmpty().WithMessage("Enter your username.");
            RuleFor(x=>x.Message).NotEmpty().WithMessage("Enter your message.");
            RuleFor(x=>x.Subject).NotEmpty().WithMessage("Enter subject.");
        }
    }
}