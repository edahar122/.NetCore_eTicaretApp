using eTicaret.Application.Repositories;
using eTicaret.Domain.Entities.Common;
using ETicaret.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace eTicaret.Persistance.Repositories {
    class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity {

        private readonly ETicaretDBContext _context;

        public WriteRepository(ETicaretDBContext context) {
            _context = context;
        }
        public DbSet<T> Table => _context.Set<T>();

        public async Task<bool> AddAsync(T model) {
            EntityEntry<T> entity = await Table.AddAsync(model);
            return entity.State == EntityState.Added;
        }

        public async Task<bool> AddRangeAsync(List<T> models) {
            await Table.AddRangeAsync(models);
            return await _context.SaveChangesAsync() > 0;
        }

        public bool Delete(T model) {
            EntityEntry<T> entity = Table.Remove(model);
            return true;
        }

        public bool DeleteRange(List<T> model) {
            Table.RemoveRange(model);
            return true;
        }

        public async Task<bool> DeleteAsync(string Id) {
            T model = await Table.FirstOrDefaultAsync(x => x.Id == Guid.Parse(Id));
            return Delete(model);
        }

        public bool Update(T model) {
            EntityEntry entityEntry = Table.Update(model);
            return entityEntry.State == EntityState.Modified;
        }

        public async Task<int> SaveAsync() {
            return await _context.SaveChangesAsync();
        }
    }
}
