using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniversityProject.Domin.Abstraction;
using UniversityProject.Domin.Entities;

namespace UniversityProject.APIs.Controllers
{
    
    public class StudentController : BaseApiController
    {
        private readonly IStudentServies _servies;

        public StudentController(IStudentServies servies)
        {
            _servies = servies;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>>GetStudents()
        {

           var students =   await _servies.GetAllStudent();
           return Ok(students);    
           

        }


    }
}
