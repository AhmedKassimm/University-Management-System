using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityProject.Domin.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public  ICollection<Student> Student { get; set; } = new HashSet<Student>();
        public ICollection<DepartmentSubject> DepartmentSubjects { get; set; } = new HashSet<DepartmentSubject>();
    }
}
