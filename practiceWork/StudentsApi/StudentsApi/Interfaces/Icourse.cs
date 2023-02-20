using StudentsApi.Models;

namespace StudentsApi.Interfaces
{
    public interface Icourse
    {
        public List<CourseTable> getAllCourses();
        //public List<CourseTable> ();
        public List<CourseTable> addNewCourse(CourseTable course);

        public List<CourseTable> updateCourse(CourseTable course);

        public string deleteCourse(int id);
    }
}
