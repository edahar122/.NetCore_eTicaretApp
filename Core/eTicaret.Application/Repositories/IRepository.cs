using Microsoft.EntityFrameworkCore;

namespace eTicaret.Application.Repositories {
    public interface IRepository<T> where T : class {
        DbSet<T> Table { get; }
    }
}