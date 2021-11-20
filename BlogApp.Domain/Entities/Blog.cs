using BlogApp.Domain.Entities.Abstract;

namespace BlogApp.Domain.Entities
{
    public class Blog : EntityBase
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}
