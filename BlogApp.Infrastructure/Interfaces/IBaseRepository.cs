using BlogApp.Domain.Entities.Abstract;

namespace BlogApp.Infrastructure.Repositories
{
    public interface IBaseRepository<T> where T : EntityBase
    {
    }
}