using BlogApp.Domain.Entities.Abstract;

namespace BlogApp.Domain.Entities
{
    public class Comment : EntityBase 
    {
        public string UserName { get; set; }
        public string Content { get; set; }
        public int PostId { get; set; }
        public virtual Post Post { get; set; }
    }
}
