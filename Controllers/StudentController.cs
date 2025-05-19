using Microsoft.AspNetCore.Mvc;
using SmartSchool.Models;
using System.Linq;

namespace SmartSchool.Controllers
{   
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        public List<Student> StudentsList = new List<Student> () {
            new Student () { 
                Id = 1,
                Name = "Flavin",
                LastName = "doPneu",
                Telephone = "111111111",
            },
            new Student () {
                Id = 2,
                Name = "Harry",
                LastName = "Balenciaga",
                Telephone = "666666666",
            },
            new Student () {
                Id = 3,
                Name = "Drauzio",
                LastName = "Vraunellas",
                Telephone = "3333333333",

            }
        };
        public StudentController() { }

        [HttpGet]
        public IActionResult Get() 
        {
            return Ok(StudentsList);
        }

        [HttpGet("byId/{id}")]
        public IActionResult GetById(int id)
        {
            var student = StudentsList.FirstOrDefault(a => a.Id == id);
            if (student == null) return BadRequest("Student not found");
            return Ok(student);
        }

        [HttpGet("byName")]
        public IActionResult GetByFullName(string name, string lastName)
        {
            var student = StudentsList.FirstOrDefault(a => 
                a.Name.Contains(name) && a.LastName.Contains(lastName)
            );
            return Ok(student);
        }

        [HttpPost]
        public IActionResult Post(Student student)
        {
            return Ok(student);
        }
        [HttpPatch("{id}")]
        public IActionResult Put(int id, Student student)
        {
            return Ok(student);
        } 

        [HttpPut("{id}")]
        public IActionResult Patch(int id, Student student)
        {
            return Ok(student);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(int id)
        {
            var aluno = StudentsList.FirstOrDefault(a => a.Id == id);
            var message = ("The student {0} with the id {1} was succesfully deleted ",aluno, id);  
            return Ok(message);
        }
    }
}