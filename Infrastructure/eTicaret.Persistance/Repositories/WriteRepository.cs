using eTicaret.Application.Repositories;
using ETicaret.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTicaret.Persistance.Repositories {
    class WriteRepository<T> : IWriteRepository<T> where T : class {

        private readonly ETicaretDBContext _context;

        public WriteRepository(ETicaretDBContext context) {
            _context = context;
        }
        DbSet<T> IRepository<T>.Table => throw new NotImplementedException();

        Task<bool> IWriteRepository<T>.AddAsync(T model) {
            throw new NotImplementedException();
        }

        Task<bool> IWriteRepository<T>.AddAsync(List<T> model) {
            throw new NotImplementedException();
        }

        Task<bool> IWriteRepository<T>.Delete(T model) {
            throw new NotImplementedException();
        }

        Task<bool> IWriteRepository<T>.Delete(string Id) {
            throw new NotImplementedException();
        }

        Task<bool> IWriteRepository<T>.UpdateAsync(T model) {
            throw new NotImplementedException();
        }
    }
}
