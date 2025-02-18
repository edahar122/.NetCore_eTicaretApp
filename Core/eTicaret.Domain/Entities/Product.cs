using eTicaret.Domain.Entities.Common;

namespace eTicaret.Domain.Entities {
    public class Product : BaseEntity {
        public string Name { get; set; }
        public int Stock { get; set; }
        public Decimal Price { get; set; }
    }
}
