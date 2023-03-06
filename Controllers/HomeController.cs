using Microsoft.AspNetCore.Mvc;

namespace TodoApp.Controllers;

[ApiController]
public class HomeController : ControllerBase
{
    [HttpGet]
    [Route("/")]
    public string Get()
    {
        return "Vasco";
    }
}