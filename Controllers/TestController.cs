using Microsoft.AspNetCore.Mvc;

public class TestController : ControllerBase
{
    private readonly ILogger<TestController> _logger;

    public TestController(ILogger<TestController> logger)
    {
        _logger = logger;
    }

    [HttpGet("test")]
    public IActionResult Get()
    {
        _logger.LogInformation("Test endpoint was called.");
        return Ok("Test endpoint is working!");
    }
}