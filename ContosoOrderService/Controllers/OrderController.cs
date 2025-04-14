using Microsoft.AspNetCore.Mvc;

namespace ContosoOrderService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { message = "This is the Order Service (dummy)" });
        }

        [HttpGet("{id}")]
        public IActionResult GetOrderById(int id)
        {
            return Ok(new { orderId = id, status = "Confirmed" });
        }
    }
}
