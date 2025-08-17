using Microsoft.AspNetCore.Mvc;

namespace TodoListTask_API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TestController : ControllerBase
	{
		private readonly ILogger<TestController> _logger;

		public TestController(ILogger<TestController> logger)
		{
			_logger = logger;
		}

		[HttpGet]
		public IActionResult Get()
		{
			_logger.LogInformation("TestController/Get được gọi - chỉ log này thôi!");
			return Ok("Test API is working!");
		}
	}
}