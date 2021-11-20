using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogApp.Domain.Entities.Abstract
{
    public abstract class EntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime Modified { get; set; }
    }
}
