using eTicaret.Application.Repositories;
using eTicaret.Domain.Entities;
using eTicaret.Persistance.Repositories;
using ETicaret.Persistance.Contexts;

namespace eTicaret.Persistance.Concretes
{
    class CustomerWriteRepository : WriteRepository<Customer>, ICustomerWriteRepository {
        public CustomerWriteRepository(ETicaretDBContext context) : base(context) {
        }
    }
}
