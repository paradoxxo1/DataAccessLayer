using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x=>x.ProductName).NotEmpty().WithMessage("Ürün İsmi Boş Geçilemez");
            RuleFor(x=>x.ProductDescription).NotEmpty().WithMessage("Ürün Açıklaması Boş Geçilemez");
            RuleFor(x=>x.ProdcutFeature).NotEmpty().WithMessage("Ürün Özellikleri Boş Geçilemez");
            RuleFor(x=>x.ProductPrice).NotEmpty().WithMessage("Ürün Ücreti Boş Geçilemez");

        }
    }
}
