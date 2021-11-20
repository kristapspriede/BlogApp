using BlogApp.Domain.Entities.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogApp.Domain.Entities
{
    public class Post : EntityBase
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int BlogId { get; set; }
        [ForeignKey("BlogId")]
        public virtual Blog Blog { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
