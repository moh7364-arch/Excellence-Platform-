using AcademicPlatform.Data;
using Microsoft.AspNetCore.Mvc;

namespace AcademicPlatform.Controllers;

public class LibraryController : Controller
{
    private readonly DemoRepository _repo;
    public LibraryController(DemoRepository repo) => _repo = repo;
    public IActionResult Index() => View(_repo.Templates);
}
