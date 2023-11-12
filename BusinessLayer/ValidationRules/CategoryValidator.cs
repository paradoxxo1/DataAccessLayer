using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x=> x.CategoryName).NotEmpty().WithMessage("Kategori Boş Geçilemez");
        }
    }
}
  