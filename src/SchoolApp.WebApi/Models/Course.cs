using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolApp.WebApi.Models;

public class Course
{
    [Key]
    public int CourseId { get; set; }
    [Required]
    public string CourseName { get; set; }
    
    public ICollection<Student> Students { get; set; }
 }