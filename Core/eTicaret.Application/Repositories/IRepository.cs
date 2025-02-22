using Microsoft.EntityFrameworkCore;

namespace eTicaret.Application.Repositories {
    public interface IRepository<T> where T : class {
        public DbSet<T> Table { get; }
    }
}