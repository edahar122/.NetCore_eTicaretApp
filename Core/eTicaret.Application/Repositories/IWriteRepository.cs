namespace eTicaret.Application.Repositories {
    public interface IWriteRepository<T> : IRepository<T> where T : class {
        Task<bool> AddAsync(T model);
        Task<bool> AddAsync(List<T> model);
        Task<bool> UpdateAsync(T model);
        Task<bool> Delete(T model);
        Task<bool> Delete(string Id);
    }
}
