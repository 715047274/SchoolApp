using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolApp.WebApi.Models;

namespace SchoolApp.WebApi.Configurations;

public class CourseEntityConfiguration : IEntityTypeConfiguration<Course>
{
    public void Configure(EntityTypeBuilder<Course> builder)
    {
        builder.HasData(
            new Course
            {
                CourseId = 1, CourseName = "MATH"
            },
            new Course {CourseId = 2, CourseName = "MicroEconomic"},
            new Course { CourseId = 3, CourseName = "Computer Science"}
        );
    }

}