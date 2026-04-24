using AcademicPlatform.Data;
using Microsoft.AspNetCore.Mvc;

namespace AcademicPlatform.Controllers;

public class StudentController : Controller
{
    private readonly DemoRepository _repo;
    public StudentController(DemoRepository repo) => _repo = repo;
    public IActionResult Dashboard() => View(_repo);
}
