using Microsoft.AspNetCore.Mvc;

namespace SmartSchool.Controllers
{   
    [ApiController]
    [Route("api")]
    public class ProfessorController : ControllerBase
    {
        public ProfessorController() { }

        [HttpGet]
        public IActionResult Get() 
        {
            return Ok("Professors: Marta, Paula");
        }
    }
}