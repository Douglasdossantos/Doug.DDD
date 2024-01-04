using Doug.Domain.Entities;
using Doug.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Doug.Infra.Repositories
{
    public class Repository<TEntity, TPK>: IRepository<TEntity,TPK> where TEntity : BaseEntity<TPK>
    {
        private readonly DbContext _context;
        private readonly DbSet<TEntity> _dbset;

        public Repository(DbContext context)
        {
            _context = context;
            _dbset = _context.Set<TEntity>();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsnc()
            => await _dbset.ToListAsync();
        public async Task<TEntity?> GetByIdAsync(TPK id)
            => await _dbset.FindAsync(id);

        public async Task InsertAsync(TEntity entity)
            => await _dbset.AddAsync(entity);
        public async Task UpdateAsync(TEntity entity)
        {
            var result = await _dbset.FindAsync(entity.Id);
            if (result != null) 
            {
                _context.Entry(result).CurrentValues.SetValues(entity);
            }
        }

        public async Task DeleteAsync(TPK id)
        {
            var entity = await _dbset.FindAsync(id);
            if (entity != null) 
            {
                _dbset.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }


    }
}
