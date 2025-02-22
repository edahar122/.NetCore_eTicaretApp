using eTicaret.Application.Repositories;
using eTicaret.Domain.Entities;
using eTicaret.Persistance.Repositories;
using ETicaret.Persistance.Contexts;

namespace eTicaret.Persistance.Concretes {
    public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository {
        public CustomerReadRepository(ETicaretDBContext context) : base(context) {
        }
    }
}
