using StudentsApi.Interfaces;
using StudentsApi.Models;

namespace StudentsApi.Repositories
{
    public class CourseRepository: Icourse
    {
        private readonly StudentsContext _courseContext;

        public CourseRepository(StudentsContext student)
        {
            _courseContext = student;
        }

        public List<CourseTable> addNewCourse(CourseTable course)
        {
            _courseContext.CourseTables.Add(course);
            _courseContext.SaveChanges();
            return getAllCourses();
        }

        public string deleteCourse(int id)
        {
            throw new NotImplementedException();
        }

        public List<CourseTable> getAllCourses()
        {
            return _courseContext.CourseTables.ToList();
        }

        public List<CourseTable> updateCourse(CourseTable course)
        {
            throw new NotImplementedException();
        }
    }
}
