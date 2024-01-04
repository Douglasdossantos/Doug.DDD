using Doug.Domain.Entities;
using Doug.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Doug.Infra.Repositories
{
    public class Repository<TEntity, TPK>: IRepository<TEntity,TPK> where TEntity : BaseEntity<TPK>
    {
        protected readonly DbContext _context;
        protected readonly DbSet<TEntity> _dbset;

        public Repository(DbContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsnc()
            => await _dbSet.ToListAsync();
        public async Task<TEntity?> GetByIdAsync(TPK id)
            => await _dbSet.FindAsync(id);

        public async Task InsertAsync(TEntity entity)
            => await _dbset.AddAsync(entity);
            
        public async Task UpdateAsync(TEntity entity)
        {
            var result = await _dbSet.FindAsync(entity.Id);
            if (result != null) 
            {
                _context.Entry(result).CurrentValues.SetValues(entity);
            }
        }

        public async Task DeleteAsync(TPK id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity != null) 
            {
                _dbSet.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
