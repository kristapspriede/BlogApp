using BlogApp.Domain.Entities;
using BlogApp.Infrastructure.DataAccess;

namespace BlogApp.Infrastructure.Repositories
{
    public class PostRepository : BaseRepository<Post>, IPostRepository
    {
        public PostRepository(MainDbContext dbContext) : base(dbContext)
        {
        }
    }
}
