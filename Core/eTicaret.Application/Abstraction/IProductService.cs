using eTicaret.Domain.Entities;

namespace eTicaret.Application.Abstraction {
    public interface IProductService {
        List<Product> GetProducts();
    }
}
