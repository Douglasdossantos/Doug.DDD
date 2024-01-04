using Doug.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doug.Domain.Interfaces.Repositories

{
    public interface IRepository<TEntity, TPK> where TEntity : BaseEntity<TPK>
    {
        Task<IEnumerable<TEntity>> GetAllAsnc();
        Task<TEntity?> GetByIdAsync(TPK id);
        Task InsertAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(TPK id);
    }
}
