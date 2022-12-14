﻿using EmployeesMvc.Models;
using EmployeesMvc.Models.Entities;
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
        public IActionResult Create(Employee employee) 
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            service.AddEmployee(employee);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet("Employees/details/{id}")]
        public IActionResult Details( int id)
        {
            var employee = service.GetEmployeeById(id);
            return View(employee);
        }

    }
}
