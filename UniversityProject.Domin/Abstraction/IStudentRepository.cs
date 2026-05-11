using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityProject.Domin.Entities;

namespace UniversityProject.Domin.Abstraction
{
    public interface IStudentRepository
    {
        public Task<IEnumerable<Student>> GetAllStudentAsync();
    }
}
