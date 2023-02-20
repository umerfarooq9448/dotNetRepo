namespace StudentsApi.Models
{
    public class StudentInfo
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string Address { get; set; }

        public string courseName { get; set; }
        public int CourseId { get; set; }

        public string CourseFee { get; set; }
    }
}
