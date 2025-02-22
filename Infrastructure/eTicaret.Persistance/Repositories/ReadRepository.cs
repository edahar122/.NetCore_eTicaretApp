using eTicaret.Application.Repositories;
using eTicaret.Domain.Entities.Common;
using ETicaret.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace eTicaret.Persistance.Repositories {
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity {

        private readonly ETicaretDBContext _context;

        public ReadRepository(ETicaretDBContext context) {
            _context = context;
        }
        public DbSet<T> Table 
            => _context.Set<T>();

        public IQueryable<T> GetAll()
            => Table;

        public async Task<T> GetByIdAsync(string Id)
            => await Table.FindAsync(Id);

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method)
            => await Table.FirstOrDefaultAsync(method);

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method)
            => Table.Where(method);
    }
}
