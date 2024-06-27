using Microsoft.EntityFrameworkCore;
using Sales.Core.Core;
using Sales.Infraestructure.Context;
using System.Linq.Expressions;


namespace Sales.Infraestructure.Core
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly DbContext context;
        private DbSet<TEntity> _entities;

        protected BaseRepository(DbContext context)
        {
            this.context = context;
            this._entities = this.context.Set<TEntity>();
        }
        public async Task<bool> Exists(Expression<Func<TEntity, bool>> filter)
        {
            return await this._entities.AnyAsync(filter);
        }

        public async Task<TEntity> Get(int id)
        {
            return await _entities.FindAsync(id);
        }

        public async Task<List<TEntity>> GetAll(Expression<Func<TEntity, bool>> filter)
        {
            return await _entities.Where(filter).ToListAsync();
        }

        public virtual async Task Save(TEntity entity)
        {
            this._entities.Add(entity);
            await this.context.SaveChangesAsync();  
        }

        public async Task Save(List<TEntity> entities)
        {
            this._entities.AddRange(entities);
            await this.context.SaveChangesAsync();
        }

        public async Task UpdateCategoria(TEntity entity)
        {
            this._entities.Update(entity);
            await this.context.SaveChangesAsync();
        }

        public async Task UpdateCategoria(List<TEntity> entities)
        {
            this._entities.UpdateRange(entities);
            await this.context.SaveChangesAsync();
        }
    }
}
