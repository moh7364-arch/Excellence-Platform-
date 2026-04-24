using AcademicPlatform.Data;
using Microsoft.AspNetCore.Mvc;

namespace AcademicPlatform.Controllers;

public class OrdersController : Controller
{
    private readonly DemoRepository _repo;
    public OrdersController(DemoRepository repo) => _repo = repo;
    public IActionResult Tracking() => View(_repo.Orders);
}
