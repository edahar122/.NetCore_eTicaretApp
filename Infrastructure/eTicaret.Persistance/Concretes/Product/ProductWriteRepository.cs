using eTicaret.Application.Repositories;
using eTicaret.Domain.Entities;
using eTicaret.Persistance.Repositories;
using ETicaret.Persistance.Contexts;

namespace eTicaret.Persistance.Concretes {
    class ProductWriteRepository : WriteRepository<Product>, IProductWriteRepository {
        public ProductWriteRepository(ETicaretDBContext context) : base(context) {
        }
    }
}
