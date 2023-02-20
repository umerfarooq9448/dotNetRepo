using StudentsApi.Models;

namespace StudentsApi.Interfaces
{
    public interface Istudents
    {
        public List<StudentsTable> getAllStudents();
        public List<StudentInfo> getAllStudents2();
        public List<StudentInfo> addNewStudent(StudentsTable student);

        public List<StudentInfo> updateStudent(StudentsTable student);

        public string deleteStudent(int id);
    }
}
