using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolApp.WebApi.Models;

public class Student
{
    [Key]
    public int StudentId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    
    
    //public int? CourseId { get; set; }
    // private IList<Course> _enrollments = new List<Course>();
    // [ForeignKey(nameof(CourseId))] 
    // public IReadOnlyList<Course> Enrollments => _enrollments.ToList();
}