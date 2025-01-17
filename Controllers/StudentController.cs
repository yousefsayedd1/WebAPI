using Microsoft.AspNetCore.Mvc;
using WebAPIDay2.Models;
using WebAPIDay2.Repositories;

namespace Web_API_Day_2.Controllers;
[Route("[controller]/[action]")]
public class StudentController
{
    private StudentRepository _studentRepository = new StudentRepository();
    [HttpGet]
    public IQueryable<Student> GetAll()
    {
        return _studentRepository.GetAll();
    }
    [HttpPost]
    public void AddStudent(Student student)
    {
         _studentRepository.AddStudent(student);
    }

}
