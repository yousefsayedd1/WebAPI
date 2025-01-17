using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using WebAPIDay2.Models;

namespace WebAPIDay2.Data;

public class Context : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=.;Integrated Security=True;Trust Server Certificate=True");

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        //modelBuilder.Entity<Student>()
        //.HasMany(e => e.Courses)
        //.WithMany(e => e.Students);
    }

    public DbSet<Course> Courses { get; set; }
    public DbSet<Student> Students { get; set; }
}
