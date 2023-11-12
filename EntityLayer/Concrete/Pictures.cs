using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Concrete
{
    public class Pictures
    {
        [Key]
        public int PictureId { get; set; }
        public string? PictureName { get; set; }
        public string? PicturePath { get; set; }
        virtual public List<Product>? Prodcuts { get; set; }

        [NotMapped] 
        public IFormFile? PictureUrl { get; set; }

    }
}
