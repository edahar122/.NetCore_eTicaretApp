using eTicaret.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace eTicaret.Application.Repositories {
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity {
        public IQueryable<T> GetAll();
        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method);
        public Task<T> GetSingleAsync(Expression<Func<T, bool>> method);
        public Task<T> GetByIdAsync(string Id);
    }
}
