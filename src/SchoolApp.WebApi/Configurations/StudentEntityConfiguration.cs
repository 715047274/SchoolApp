using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolApp.WebApi.Models;

namespace SchoolApp.WebApi.Configurations;

public class StudentEntityConfiguration: IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.HasData(new Student {StudentId = 1, Email = "alice@gmail.com", Name = "Alice"}, new Student
        {
            StudentId = 2, Email = "bob@outlook.com", Name = "Bob"
        });
    }
}