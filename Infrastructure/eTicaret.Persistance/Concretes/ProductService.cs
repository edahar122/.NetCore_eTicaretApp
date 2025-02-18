using eTicaret.Application.Abstraction;
using eTicaret.Domain.Entities;

namespace eTicaret.Persistance.Concretes {
    public class ProductService : IProductService {
        public List<Product> GetProducts()
            => new() {
                new() {
                    Id = Guid.NewGuid(),
                    Name = "urun1",
                    Stock = 5,
                    Price = 100
                },
                new() {
                     Id = Guid.NewGuid(),
                    Name = "urun2",
                    Stock = 15,
                    Price = 150
                }
            };

    }
}
