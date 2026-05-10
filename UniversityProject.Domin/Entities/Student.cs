using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityProject.Domin.Entities
{
    public class Student
    {

        public int StuId { get; set; }
        public string Name { get; set; } = default!;
        public string Address { get; set; } = default!;
        public string Phone { get; set; } = default!;

        public int DepartmentId { get; set; }  // FK Column 
        public  Department Departments { get; set; }  // NP 1 to M [Department]
         



    }
}
