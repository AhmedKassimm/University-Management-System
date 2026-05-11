using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityProject.Domin.Abstraction;
using UniversityProject.Domin.Entities;

namespace UniversityProject.Service.Servies.StudentServies
{
    public class StudentServcies : IStudentServies
    {
        private readonly IStudentRepository _repo;

        public StudentServcies(IStudentRepository repo)
        {
    
            _repo = repo;
        }
        public async Task<IEnumerable<Student>> GetAllStudent()
        {
            var students = await _repo.GetAllStudentAsync();
           return students.Where(S => S.Address  == "Cairo"); // Logic
        }
    }
}
