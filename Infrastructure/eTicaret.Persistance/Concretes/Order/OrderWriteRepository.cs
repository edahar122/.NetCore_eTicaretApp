using eTicaret.Application.Repositories;
using eTicaret.Domain.Entities;
using eTicaret.Persistance.Repositories;
using ETicaret.Persistance.Contexts;

namespace eTicaret.Persistance.Concretes {
    class OrderWriteRepository : WriteRepository<Order>, IOrderWriteRepository {
        public OrderWriteRepository(ETicaretDBContext context) : base(context) {
        }
    }
}
