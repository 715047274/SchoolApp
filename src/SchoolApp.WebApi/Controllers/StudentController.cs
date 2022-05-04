using Microsoft.AspNetCore.Mvc;
using SchoolApp.WebApi.Dto;
using SchoolApp.WebApi.Models;
using SchoolApp.WebApi.Repositories;

namespace SchoolApp.WebApi.Controllers;

[Route("api/student")]
[ApiController]
public class StudentController : ControllerBase
{
    private readonly StudentRepository _repository;

    public StudentController(StudentRepository repo)
    {
        _repository = repo;
    }

    [HttpGet]
    [Route("getAll")]
    public async Task<IActionResult> GetStudents()
    {
        var studentList = await _repository.GetAllStudent();
        return Ok(studentList);
    }

    [HttpGet("{id:int}", Name = "GetStudent")]
    public async Task<IActionResult> GetStudent(int id)
    {
        return Ok(await _repository.GetStudent(id));
    }

    [HttpPost]
    [Route("update")]
    public async Task<IActionResult> UpdateStudent([FromBody] Student student)
    {
        var isSuccess = await _repository.UpdateStudent(student);
        return Ok(new {updated = isSuccess});
    }

    [HttpPost]
    [Route("Create")]
    public async Task<IActionResult> CreateStudent([FromBody] CreateStudentDto student)
    {
        //throw new NotImplementedException();
        return Ok(await _repository.RegisterStudent(student));
    }

    [HttpDelete]
    [Route("unregister")]
    public async Task<IActionResult> UnRegisterStudent(int id)
    {
        var isSuccess = await _repository.DeleteStudent(id);
        return Ok(new {updated = isSuccess});
    }
}