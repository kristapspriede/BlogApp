using BlogApp.Domain.Entities.Abstract;

namespace BlogApp.Domain.Entities
{
    public class Post : EntityBase
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
