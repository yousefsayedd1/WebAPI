using WebAPIDay2.Models;
using WebAPIDay2.Data;
using Microsoft.AspNetCore.Mvc;
namespace WebAPIDay2.Repositories;


public class GenericRepository
{

}
public class StudentRepository : GenericRepository
{

    private readonly Context _context = new Context();

    public IQueryable<Student> GetAll()
    {
        return _context.Students;
    }

    public Student GetStudentById(int id)
    {
        return _context.Students.FirstOrDefault(x => x.id == id);
    }


    public void AddStudent(Student student)
    {
        _context.Students.Add(student);
        _context.SaveChanges();
    }
    public void UpdateStudent(Student student)
    {
        _context.Students.Update(student);
        _context.SaveChanges();
    }
    [HttpDelete]
    public void DeleteStudent(int id)
    {
        var student = _context.Students.FirstOrDefault(x => x.id == id);
        _context.Students.Remove(student);
        _context.SaveChanges();
    }


}
