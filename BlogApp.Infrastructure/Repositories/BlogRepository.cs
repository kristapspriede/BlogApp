using BlogApp.Domain.Entities;
using BlogApp.Infrastructure.DataAccess;

namespace BlogApp.Infrastructure.Repositories
{
    public class BlogRepository : BaseRepository<Blog>, IBlogRepository
    {
        public BlogRepository(MainDbContext dbContext) : base(dbContext)
        {
        }
    }
}
