using Microsoft.AspNetCore.Mvc;

namespace EmployeesMvc.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
