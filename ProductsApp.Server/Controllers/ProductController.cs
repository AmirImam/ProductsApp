using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductsApp.Models;

namespace ProductsApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly DataBase db;

        public ProductController(DataBase db)
        {
            this.db = db;
        }

        [HttpGet]
        public List<Product> Get() => db.Products;
        [HttpGet]
        [Route("/api/Product/Get/{id}")]
        public Product? GetById(Guid id)
            => db.Products.FirstOrDefault(it => it.Id == id);
        [HttpPost]
        public IActionResult Create(Product product)
        {
            db.Products.Add(product);
            return Ok(product);
        }
    }
}
