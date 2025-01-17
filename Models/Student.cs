namespace WebAPIDay2.Models;

public class Student : BaseModel
{
    public Student()
    {
        Courses = new List<Course>();
    }
    public string Name { get; set; }
    public ICollection<Course> Courses { get; set; }


}
