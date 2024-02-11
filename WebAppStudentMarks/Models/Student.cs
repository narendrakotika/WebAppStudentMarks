using System.ComponentModel.DataAnnotations;

namespace WebAppStudentMarks.Models
{
    public class Student
    {
       [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public int  Section { get; set; }
        public DateTime DOB { get; set; }
    }
}
