
using System.Linq.Expressions;


namespace Sales.Core.Core
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task Save(TEntity entity);
        Task Save(List<TEntity> entities);
        Task UpdateCategoria(TEntity entity);
        Task UpdateCategoria(List<TEntity> entities);
        Task<TEntity> Get(int id);
        Task<List<TEntity>> GetAll(Expression<Func<TEntity, bool>> filter);
        Task<bool> Exists(Expression<Func<TEntity, bool>> filter);
    }
    
}

