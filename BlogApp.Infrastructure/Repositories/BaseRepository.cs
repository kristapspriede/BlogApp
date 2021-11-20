using BlogApp.Domain.Entities.Abstract;
using BlogApp.Infrastructure.DataAccess;

namespace BlogApp.Infrastructure.Repositories
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : EntityBase
    {
        protected readonly MainDbContext _dbContext;

        public BaseRepository(MainDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public T Get(int id)
        {
            return _dbContext.Set<T>().Find(id);
        }
        public IQueryable<T> GetAll()
        {
            return _dbContext.Set<T>();
        }

        public void Add(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update(T entity)
        {
            _dbContext.Set<T>().Update(entity);
            _dbContext.SaveChanges();
        }
    }
}
