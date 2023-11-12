using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Comments
    {
        [Key]
        public int CommentsId { get; set; }
        public string? Commenter { get; set; }
        public string? CommentText { get; set; }
        public DateTime CommentDate { get; set; }
        public int? ProductId { get; set;}
        virtual public Product? Products { get; set; }

    }
}
 