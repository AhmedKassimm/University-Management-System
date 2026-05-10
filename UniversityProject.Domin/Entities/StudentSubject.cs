using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityProject.Domin.Entities
{
    public class StudentSubject
    {
        public int StuSubId { get; set; }
        public int StudentId  { get; set; }
        public int SubjectId { get; set; }
        [ForeignKey("StudentId")]
        public Student Students { get; set; } = default!;
        [ForeignKey("SubjectId")]
        public Subject Subjects { get; set; } = default!;

    }
}