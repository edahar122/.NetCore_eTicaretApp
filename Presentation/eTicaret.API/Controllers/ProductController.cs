using eTicaret.Application.Abstraction;
using eTicaret.Application.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace eTicaret.API.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase {

        private readonly IProductReadRepository _productReadRepository;
        private readonly IProductWriteRepository _productWriteRepository;
        public ProductController(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository) {
            _productReadRepository = productReadRepository;
            _productWriteRepository = productWriteRepository;
        }
        [HttpGet]
        public IActionResult GetProducts() {
            var products = _productReadRepository.GetAll();
            return Ok(products);
        }

        [HttpPost]
        public async Task Add() {
           await _productWriteRepository.AddRangeAsync(new() {
                new() {
                    Id = Guid.NewGuid(),
                    Name = "Product 1",
                    Price = 100,
                    Stock = 150,
                    CreateDate = DateTime.UtcNow
                },
                new() {
                    Id = Guid.NewGuid(),
                    Name = "Product 2",
                    Price = 100,
                    Stock = 150,
                    CreateDate = DateTime.UtcNow
                }
            });
            await _productWriteRepository.SaveAsync();
            
        }
    }
}
