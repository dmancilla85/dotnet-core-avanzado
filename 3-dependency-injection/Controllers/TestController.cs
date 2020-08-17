
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        private readonly IDatabase db; 

        public TestController(IDatabase db)
        {
            this.db = db;
        }

        [HttpGet]
        public IActionResult Get()
        {
            //db.Create();
            //var result = db.GetProducts();
            //return Ok(result);
            var ticks = HttpContext.Items["ticks"];
            return Ok($"Dependencia: {db.Ticks} Middleware: {ticks}");
        }
    }
}
