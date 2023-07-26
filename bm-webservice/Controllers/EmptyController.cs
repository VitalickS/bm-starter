using Microsoft.AspNetCore.Mvc;

namespace BmWebService.Controllers;

[ApiController]
[Route("[controller]")]
public class EmptyController : ControllerBase
{
    private readonly ILogger<EmptyController> _logger;

    public EmptyController(ILogger<EmptyController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "Ping")]
    public string Get()
    {
        return "Pong";
    }
}
