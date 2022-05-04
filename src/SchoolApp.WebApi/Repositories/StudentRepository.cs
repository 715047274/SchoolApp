using Microsoft.EntityFrameworkCore;
using SchoolApp.WebApi.Configurations;
using SchoolApp.WebApi.Dto;
using SchoolApp.WebApi.Models;

namespace SchoolApp.WebApi.Repositories;

public class StudentRepository : IStudentRepository
{
    private readonly SchoolAppContext _context;

    public StudentRepository(SchoolAppContext context)
    {
        _context = context;
    }

    public async Task<List<Student>> GetAllStudent()
    {
        return await _context.Students.ToListAsync();
    }

    public async Task<Student> GetStudent(int id)
    {
        return await _context.Students.SingleOrDefaultAsync(s => s.StudentId == id);
    }

    public async Task<bool> UpdateStudent(Student student)
    {
        _context.Students.Attach(student);
        _context.Entry(student).State = EntityState.Modified;
        try
        {
            return await _context.SaveChangesAsync() > 0 ? true : false;
        }
        catch (Exception exp)
        {
            Console.Write(exp);
        }

        return false;
    }

    public async Task<bool> DeleteStudent(int id)
    {
        // throw new NotImplementedException();
        var student = await _context.Students.SingleOrDefaultAsync(s => s.StudentId == id);
        _context.Remove(student);
        try
        {
            return await _context.SaveChangesAsync() > 0 ? true : false;
        }
        catch (Exception exp)
        {
            Console.WriteLine("error delete");
        }

        return false;
    }

    public async Task<Student> RegisterStudent(CreateStudentDto student)
    {
        var newStudent = new Student {Name = student.Name, Email = student.Email};
        _context.Students.Add(newStudent);
        try
        {
            await _context.SaveChangesAsync();
        }
        catch (Exception exp)
        {
            Console.WriteLine(exp);
        }

        return newStudent;
    }
}