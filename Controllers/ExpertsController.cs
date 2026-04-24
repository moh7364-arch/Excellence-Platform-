using AcademicPlatform.Data;
using Microsoft.AspNetCore.Mvc;

namespace AcademicPlatform.Controllers;

public class ExpertsController : Controller
{
    private readonly DemoRepository _repo;
    public ExpertsController(DemoRepository repo) => _repo = repo;
    public IActionResult Index() => View(_repo.Experts);
}
