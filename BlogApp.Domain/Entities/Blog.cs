using BlogApp.Domain.Entities.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogApp.Domain.Entities
{
    public class Blog : EntityBase
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}
