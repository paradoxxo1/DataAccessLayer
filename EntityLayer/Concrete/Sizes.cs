using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Sizes
    {
        [Key]
        public int SizeId { get; set; }
        public string? SizeName { get; set; }
        virtual public List<Product>? Prodcuts { get; set; }
    }
}
