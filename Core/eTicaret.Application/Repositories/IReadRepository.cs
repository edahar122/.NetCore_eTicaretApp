using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace eTicaret.Application.Repositories {
    public interface IReadRepository<T> : IRepository<T> where T : class {
        IQueryable<T> GetAll();
        IQueryable<T> GetWhere(Expression<Func<T, bool>> method);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> method);
        Task<T> GetByIdAsync(string Id);
    }
}
