using AcademicPlatform.Data;
using Microsoft.AspNetCore.Mvc;

namespace AcademicPlatform.Controllers;

public class ForumController : Controller
{
    private readonly DemoRepository _repo;
    public ForumController(DemoRepository repo) => _repo = repo;
    public IActionResult Index() => View(_repo.Posts);
}
