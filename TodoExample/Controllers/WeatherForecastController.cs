using Microsoft.AspNetCore.Mvc;

namespace TodoExample.Controllers;

public record RequestData(string Title);

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }
    
    [HttpPost]
    public IActionResult Post(RequestData request)
    {
        return StatusCode(StatusCodes.Status201Created, request);
    }
}