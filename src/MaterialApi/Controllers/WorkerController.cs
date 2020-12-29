using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MaterialApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WorkerController : ControllerBase
    {
        private readonly ILogger<WorkerController> _logger;

        public WorkerController(ILogger<WorkerController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
