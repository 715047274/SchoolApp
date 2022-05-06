using SchoolApp.WebApi.Models;

namespace SchoolApp.WebApi.Repositories;

public interface IUnitOfWork: IDisposable
{
    IGenericRepository<Student>  Students { get; set; }
    IGenericRepository<Course> Course { get; }
    Task Save();
}