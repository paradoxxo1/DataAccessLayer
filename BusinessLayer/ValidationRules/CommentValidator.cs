using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class CommentValidator : AbstractValidator<Comments>
    {
        public CommentValidator()
        {
            RuleFor(x=> x.CommentText).NotEmpty().WithMessage("Yorum satırı boş bırakılamaz");
            RuleFor(x=> x.Commenter).NotEmpty().WithMessage("Yazar içerği Boş Bırakılamaz");
        }
    }
}
