using AcademicPlatform.Data;
using Microsoft.AspNetCore.Mvc;

namespace AcademicPlatform.Controllers;

public class HomeController : Controller
{
    private readonly DemoRepository _repo;
    public HomeController(DemoRepository repo) => _repo = repo;
    public IActionResult Index() => View(_repo);
    public IActionResult Services() => View(_repo);
    public IActionResult Contact() => View();
}
