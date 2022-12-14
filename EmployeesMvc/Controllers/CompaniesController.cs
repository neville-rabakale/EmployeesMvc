using EmployeesMvc.Models;
using EmployeesMvc.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesMvc.Controllers
{
    public class CompaniesController : Controller
    {
        DataService service;
        public CompaniesController(DataService service)
        {
            this.service= service;
        }

        [HttpGet("Company")]
        [HttpGet("Company/index")]
        public IActionResult Index()
        {
            var model = service.GetAllCompanies();
            return View(model);
        }

        [HttpGet("Company/create")]
        public IActionResult Create()
        {   
            return View();
        }

        [HttpPost("Company/create")]
        public IActionResult Create(Company company) 
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            service.AddCompany(company);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet("Company/details/{id}")]
        public IActionResult Details( int id)
        {
            var employee = service.GetCompanyById(id);
            return View(employee);
        }

    }
}
