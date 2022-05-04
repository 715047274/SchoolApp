using Microsoft.AspNetCore.Mvc;

namespace SchoolApp.WebApi.Controllers;

[ApiController]
[Route("school")]
public class SchoolController : ControllerBase
{
    public SchoolController()
    {
    }

    [HttpGet]
    public IActionResult GetCourses()
    {
        return Ok(new
        {
            Name = "cat"
        });
    }
}