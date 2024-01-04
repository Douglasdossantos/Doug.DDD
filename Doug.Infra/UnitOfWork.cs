using Doug.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Doug.Infra
{
    public class UnitOfWork<TContext> : IUnitOfWork<TContext> where TContext : DbContext
    {
        private readonly TContext _context;

        public UnitOfWork(TContext context)
        {
            _context = context;
        }

        public async Task CommitAsync()
        => await _context.SaveChangesAsync();
    }
}
