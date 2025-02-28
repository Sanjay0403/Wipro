using DemoWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        static List<Student> students = null;
        public StudentController()
        {
            if (students == null)
            {
                students = new List<Student>()
                {
                    new Student()
                    {
                        Id = 1,
                        Name = "ajay",
                        Batch = "B001",
                        JoiningDate = new DateTime(),
                        Marks = 90
                    },

                    new Student()
                    {
                        Id = 2,
                        Name = "vijay",
                        Batch = "B002",
                        JoiningDate = new DateTime(),
                        Marks = 91
                    },

                    new Student()
                    {
                        Id = 3,
                        Name = "jay",
                        Batch = "B001",
                        JoiningDate = DateTime.Parse("12/12/2024"),
                        Marks = 90
                    },

                    new Student()
                    {
                        Id = 4,
                        Name = "deepak",
                        Batch = "B001",
                        JoiningDate = new DateTime(),
                        Marks = 90
                    },

                    new Student()
                    {
                        Id = 5,
                        Name = "gagan",
                        Batch = "B001",
                        JoiningDate = new DateTime(),
                        Marks = 90
                    }
                };
            }
        }

        // crud , r
        [HttpGet]
        public List<Student> Get()
        {
            return students;

        }
        [HttpGet("{id}")]  // read
        public Student GetById(int id)
        {
            return students.FirstOrDefault(x => x.Id == id);

        }
        [HttpPost]  // create

        public void AddStudent(Student student)
        {
            students.Add(student);
        }
        [HttpDelete("{id}")]
        public void DeleteStudent(int id)
        {
            Student student = students.FirstOrDefault(x => x.Id == id);
            students.Remove(student);
        }
        [HttpPut("{id}")]
        public void EditStudent(int id, Student student)
        {
            Student obj = students.FirstOrDefault(x => x.Id == id);
            obj.Batch = student.Batch;
        }

    }

    }

