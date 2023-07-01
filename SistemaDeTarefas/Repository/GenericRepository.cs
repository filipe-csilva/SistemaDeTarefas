using Microsoft.EntityFrameworkCore;
using ApiDeTarefas.Data;
using ApiDeTarefas.Repository.Interfaces;

namespace ApiDeTarefas.Repository
{
    public abstract class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly SystemContext _context;

        public GenericRepository(SystemContext context)
        {
            _context = context;
        }

        public async Task<TEntity?> SearchById(params object[] keys)
        {
            return await _context.FindAsync<TEntity>(keys);
        }

        public virtual async Task<TEntity> GetById(params object[] keys)
        {
            return await _context.FindAsync<TEntity>(keys) ?? throw new KeyNotFoundException();
        }

        public virtual async Task<ICollection<TEntity>> GetAll()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> Add(TEntity entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> Update(TEntity entity, params object[] keys)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> Delete(params object[] keys)
        {
            TEntity entity = await GetById(keys);
            _context.Remove(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}