using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace TodoExample.Controllers;

public record RequestData(string Title);

public class RequestDataValidator : AbstractValidator<RequestData>
{
    public RequestDataValidator()
    {
        RuleFor(x => x.Title).NotEmpty().MaximumLength(10);
    }
}

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