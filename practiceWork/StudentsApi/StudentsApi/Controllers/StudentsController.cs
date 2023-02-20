using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentsApi.Interfaces;
using StudentsApi.Models;

namespace StudentsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly Istudents _students;

        public StudentsController(Istudents students)
        {
            _students = students;
        }

        //[HttpGet]
        //public List<StudentsTable> getAllStudents()
        //{
        //    return _students.getAllStudents();
        //}

        [HttpGet]
        public List<StudentInfo> getAllStudents2()
        {
            return _students.getAllStudents2();
        }

        [HttpDelete]
        public string deleteStudent(int id) { 
        
        return _students.deleteStudent(id);
        
        }

        [HttpPost]
        public List<StudentInfo> addNewStudent(StudentsTable student)
        {
            return _students.addNewStudent(student);
        }

        [HttpPut]
        public List<StudentInfo> updateStudent(StudentsTable student)
        {
            return _students.updateStudent(student);
        }

    }
}
