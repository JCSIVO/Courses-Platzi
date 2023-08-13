using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webapi;

namespace Proyecto.Controllers;

[ApiController]
[Route("api/[controller]")]

public class HelloWorldController : ControllerBase
{
    IHelloWorldService helloWorldService;

    TareasContext dbcontext;

    private readonly ILogger<HelloWorldController> _logger;

    public HelloWorldController(ILogger<HelloWorldController> logger, IHelloWorldService helloWorld, TareasContext db)
    {
        _logger = logger;
        helloWorldService = helloWorld;
        dbcontext = db;
    }

    [HttpGet]
    public  IActionResult Get()
    {
        _logger.LogInformation("Saludos para el mundo");
        return Ok(helloWorldService.GetHelloWorld());
    }
    
    [HttpGet]
    [Route("createdb")]
    public IActionResult CreateDatabase()
    {
        dbcontext.Database.EnsureCreated();

        return Ok();
    }
}