using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductsApp.Models;

namespace ProductsApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly DataBase db;

        public OrderController(DataBase db)
        {
            this.db = db;
        }

        [HttpGet]
        public List<Order> Get() => db.Orders;

        [HttpPost]
        public IActionResult Create(Order order)
        {
            db.Orders.Add(order);
            return Ok(order);
        }
    }
}
