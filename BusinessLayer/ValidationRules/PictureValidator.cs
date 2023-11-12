using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class PictureValidator : AbstractValidator<Pictures>
    {
        public PictureValidator()
        {
            RuleFor(x => x.PictureUrl).NotEmpty().WithMessage("Resim URL'si Boş geçilemez yada hatalı URL");
        }
    }
}
