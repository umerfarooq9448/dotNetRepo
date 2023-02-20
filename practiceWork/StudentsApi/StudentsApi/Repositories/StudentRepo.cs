using StudentsApi.Interfaces;
using StudentsApi.Models;

namespace StudentsApi.Repositories
{
    public class StudentRepo: Istudents
    {
        private readonly StudentsContext _studentContext;

        public StudentRepo(StudentsContext student)
        {
            _studentContext= student;
        }

        public List<StudentInfo> addNewStudent(StudentsTable student)
        {
             _studentContext.StudentsTables.Add(student);
             _studentContext.SaveChanges();
            return getAllStudents2();
        }

        public string deleteStudent(int id)
        {
            var new_id = _studentContext.StudentsTables.Find(id);
            _studentContext.StudentsTables.Remove(new_id);
            _studentContext.SaveChanges() ;

            return "Deleted";
        }

        public List<StudentsTable> getAllStudents()
        {
             return _studentContext.StudentsTables.ToList(); 
            

        }
        public List<StudentInfo> getAllStudents2()
        {
            // return _studentContext.StudentsTables.ToList(); 
            var studentList = (from st in _studentContext.StudentsTables
                               join Course in _studentContext.CourseTables on st.CourseId equals Course.CourseId
                               select new StudentInfo()
                               {
                                   StudentId = st.StudentId,
                                   StudentName = st.StudentName,
                                   Address = st.Address,
                                   CourseId = Course.CourseId,
                                   courseName = Course.CourseName,
                                   CourseFee = Course.Fee


                               }).ToList();
            return studentList;

        }

        public List<StudentInfo> updateStudent(StudentsTable student)
        {
            var stud = _studentContext.StudentsTables.Find(student.StudentId);
            stud.StudentName = student.StudentName;
            stud.Address = student.Address;
            stud.CourseId = student.CourseId;
            _studentContext.SaveChanges();

            return getAllStudents2();
        }
    }
}
