using eTicaret.Domain.Entities.Common;

namespace eTicaret.Application.Repositories {
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity {
        Task<bool> AddAsync(T model);
        Task<bool> AddRangeAsync(List<T> model);
        bool Update(T model);
        bool Delete(T model);
        bool DeleteRange(List<T> model);
        Task<bool> DeleteAsync(string Id);
        Task<int> SaveAsync();
    }
}
