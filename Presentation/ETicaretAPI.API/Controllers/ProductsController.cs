using ETicaretAPI.Application.Abstractions;
using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IProductWriteRepository _productWriteRepository;
        private readonly IProductReadRepository _producReadRepository;

        public ProductsController(IProductService productService, IProductWriteRepository productWriteRepository, IProductReadRepository producReadRepository)
        {
            _productService = productService;
            _productWriteRepository = productWriteRepository;
            _producReadRepository = producReadRepository;
        }

        [HttpGet]
        public async Task Get()
        {
            //await _productWriteRepository.AddRangeAsync(new()
            //{
            //    new() {Id=Guid.NewGuid(), Name = "Product 1", Price = 100, CreatedDate = DateTime.UtcNow, Stock=10},
            //    new() {Id=Guid.NewGuid(), Name = "Product 2", Price = 200, CreatedDate = DateTime.UtcNow, Stock=20},
            //    new() {Id=Guid.NewGuid(), Name = "Product 3", Price = 300, CreatedDate = DateTime.UtcNow, Stock=30},
            //});
            //var count = await _productWriteRepository.SaveAsync();
            //Product p = await _producReadRepository.GetByIdAsync("218ab499-73fb-44b1-afaf-b25168d46fc4" , false);
            //p.Name = "Mehmet";
            //await _productWriteRepository.SaveAsync();

            //var products = _producReadRepository.GetAll(); 
            var product3 = await _producReadRepository.GetByIdAsync("280f1542-191e-41ec-8a5a-cdede75186be");
            product3.Stock = 19;

            await _productWriteRepository.SaveAsync();

        }

        //[HttpGet]
        //public IActionResult GetProducts()
        //{
        //    var products = _productService.GetProducts();
        //    return Ok(products);
        //}
    }
}
