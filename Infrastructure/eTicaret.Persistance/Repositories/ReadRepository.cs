using eTicaret.Application.Repositories;
using ETicaret.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;

namespace eTicaret.Persistance.Repositories {
    public class ReadRepository<T> : IReadRepository<T> where T : class {

        private readonly ETicaretDBContext _context;

        public ReadRepository(ETicaretDBContext context) {
            _context = context;
        }
        DbSet<T> IRepository<T>.Table => throw new NotImplementedException();

        IQueryable<T> IReadRepository<T>.GetAll() {
            throw new NotImplementedException();
        }

        Task<T> IReadRepository<T>.GetByIdAsync(string Id) {
            throw new NotImplementedException();
        }

        Task<T> IReadRepository<T>.GetSingleAsync(System.Linq.Expressions.Expression<Func<T, bool>> method) {
            throw new NotImplementedException();
        }

        IQueryable<T> IReadRepository<T>.GetWhere(System.Linq.Expressions.Expression<Func<T, bool>> method) {
            throw new NotImplementedException();
        }
    }
}
