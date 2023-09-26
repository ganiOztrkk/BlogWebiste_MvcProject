using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Category Name Must Be Written.");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Minimum 3 Characters");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("Maximum 20 Characters");
            RuleFor(x => x.CategoryDescription).MaximumLength(200).WithMessage("Maximum 200 Characters");
        }
    }
}