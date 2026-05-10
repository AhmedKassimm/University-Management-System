using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityProject.Domin.Entities
{
    public class DepartmentSubject
    {
        public int  DeptSubId { get; set; }
        public int  DepartmentId { get; set; }
        public int  SubjectId { get; set; }
        [ForeignKey("DepartmentId")]
        public Department Department { get; set; } = default!; 
        [ForeignKey("SubjectId")]
        public Subject Subject { get; set; } = default!;  
    }
}