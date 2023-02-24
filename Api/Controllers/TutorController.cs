using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TutorController : ControllerBase
    {
        private readonly ILogger<TutorController> _logger;

        public TutorController(ILogger<TutorController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public Task<IActionResult> Get([FromQuery] TutorsQuery query)
        {
            return Task.FromResult<IActionResult>(Ok(DateTime.UtcNow));
        }

        [HttpPost]
        public Task<IActionResult> Post([FromBody] CreateTutor command)
        {
            return Task.FromResult<IActionResult>(Created(Guid.NewGuid().ToString(), null));
        }
    }

    public class TutorsQuery
    {
        public Guid TutorId { get; set; }
    }

    public class CreateTutor
    {
        public string Name { get; set; }
    }
}