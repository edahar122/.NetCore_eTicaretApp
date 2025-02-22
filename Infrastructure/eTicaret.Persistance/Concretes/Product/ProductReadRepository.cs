using eTicaret.Application.Repositories;
using eTicaret.Domain.Entities;
using eTicaret.Persistance.Repositories;
using ETicaret.Persistance.Contexts;

namespace eTicaret.Persistance.Concretes {
    class ProductReadRepository : ReadRepository<Product>, IProductReadRepository {
        public ProductReadRepository(ETicaretDBContext context) : base(context) {
        }
    }
}
