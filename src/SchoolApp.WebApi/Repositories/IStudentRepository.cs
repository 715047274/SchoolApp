using SchoolApp.WebApi.Dto;
using SchoolApp.WebApi.Models;

namespace SchoolApp.WebApi.Repositories;

public interface IStudentRepository
{
    Task<List<Student>> GetAllStudent();
    Task<Student> GetStudent(int id);
    Task<bool> UpdateStudent(Student student);
    Task<bool> DeleteStudent(int id);
    Task<Student> RegisterStudent(CreateStudentDto student);
}