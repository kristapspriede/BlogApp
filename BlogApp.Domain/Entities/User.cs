using BlogApp.Domain.Entities.Abstract;

namespace BlogApp.Domain.Entities
{
    public class User : EntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }

        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
    }
}
