using BlogApp.Domain.Entities.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogApp.Domain.Entities
{
    public class Comment : EntityBase 
    {
        public string UserName { get; set; }
        public string Content { get; set; }
        public int PostId { get; set; }
        [ForeignKey("PostId")]
        public virtual Post Post { get; set; }
    }
}
