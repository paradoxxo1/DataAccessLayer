using EntityLayer.Concrete;
using FluentValidation;
using System.Drawing;

namespace BusinessLayer.ValidationRules
{
    public class ColorValidator : AbstractValidator<Colors>
    {
        public ColorValidator()
        {
            RuleFor(x=> x.ColorName).NotEmpty().WithMessage("Rengin İsmini Boş Bırakmayınız");
        }
    }
}
