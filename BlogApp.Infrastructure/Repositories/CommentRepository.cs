using BlogApp.Domain.Entities;
using BlogApp.Infrastructure.DataAccess;

namespace BlogApp.Infrastructure.Repositories
{
    public class CommentRepository : BaseRepository<Comment>, ICommentRepository
    {
        public CommentRepository(MainDbContext dbContext) : base(dbContext)
        {
        }
    }
}
