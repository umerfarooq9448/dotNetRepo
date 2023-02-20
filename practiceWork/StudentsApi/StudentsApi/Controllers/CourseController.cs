using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentsApi.Interfaces;
using StudentsApi.Models;

namespace StudentsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly Icourse _course;
        public CourseController(Icourse course)
        {
            _course = course;
        }

        [HttpGet]
        public List<CourseTable> getAllCourses()
        {
            return _course.getAllCourses();
        }
    }
}
