using BlogApp.Domain.Entities;
using BlogApp.Infrastructure.DataAccess;

namespace BlogApp.Infrastructure.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(MainDbContext dbContext) : base(dbContext)
        {
        }
    }
}
