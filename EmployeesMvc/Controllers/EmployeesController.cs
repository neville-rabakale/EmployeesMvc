using EmployeesMvc.Models;
using EmployeesMvc.Models.Entities;
using EmployeesMvc.Views.Employees;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesMvc.Controllers
{
    public class EmployeesController : Controller
    {
        DataService service;
        public EmployeesController(DataService service)
        {
            this.service= service;
        }

      
        [HttpGet("Employees/index")]
        public IActionResult Index()
        {
            var model = service.GetAllEmployees();
            return View(model);
        }

        [HttpGet("Employees/create")]
        public IActionResult Create()
        {   
            return View();
        }

        [HttpPost("Employees/create")]
        public IActionResult Create(CreateVM model) 
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            service.AddEmployee(model);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet("Employees/details/{id}")]
        public IActionResult Details( int id)
        {
            var employee = service.GetEmployeeDetails(id);
            return View(employee);
        }

    }
}
