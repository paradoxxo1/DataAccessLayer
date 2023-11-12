using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Colors
    {
        [Key]
        public int ColorId { get; set; }
        public string? ColorName { get; set; }
        public string? ColorCode { get; set; }
        virtual public List<Product>? Prodcuts { get; set; }
    }
}
