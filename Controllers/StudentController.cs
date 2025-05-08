using Microsoft.AspNetCore.Mvc;

namespace SmartSchool.Controllers
{   
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        public StudentController() { }

        [HttpGet]
        public IActionResult Get() 
        {
            return Ok("Students: Marta, Paula");
        }
    }
}