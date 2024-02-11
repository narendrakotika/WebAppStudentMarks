namespace WebAppStudentMarks.Models
{
    public class Mark
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int SubjectCode { get; set; }
        public int Score { get; set; }
        public DateTime Date { get; set; }

    }
}
