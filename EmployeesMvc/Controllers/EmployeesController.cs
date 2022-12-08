using EmployeesMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesMvc.Controllers
{
    public class EmployeesController : Controller
    {
        DataService service;
        public EmployeesController()
        {
            service= new DataService();
        }

        [HttpGet("")]
        [HttpGet("index")]
        public IActionResult Index()
        {
            var model = service.GetAllEmployees();
            return View(model);
        }

        [HttpGet("create")]
        public IActionResult Create()
        {   
            return View();
        }

        [HttpPost("create")]
        public IActionResult Create(Employee employee) 
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            service.AddEmployee(employee);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet("details/{id}")]
        public IActionResult Details( int id)
        {
            var employee = service.GetEmployeeById(id);
            return View(employee);
        }

    }
}
