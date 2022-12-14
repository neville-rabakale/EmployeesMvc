using EmployeesMvc.Models.Entities;
using System.Text.Json;

namespace EmployeesMvc.Models
{
    public class DataService
    {
        private readonly EmployeeContext context;

        //List<Employee> Employees = new List<Employee>
        //{
        //    new Employee { Id = 0, Name= "Jon", Email = "jon@gmail.com"},
        //    new Employee { Id = 1, Name= "Boli", Email = "boli@gmail.com"},
        //    new Employee { Id = 2, Name= "Anne", Email = "anne@gmail.com"},
        //};
        public DataService(EmployeeContext context)
        {
            this.context = context;
        }

        public void AddEmployee(Employee employee)
        {
            context.Employees.Add(employee);
            context.SaveChanges();
        }

        public void AddEmployeeJson(Employee employee)
        {
            employee.Id = context.Employees.Max(x => x.Id) + 1;
            string json = JsonSerializer.Serialize(employee);
            string fileName = "EmployeeData.js";
            File.WriteAllText(fileName, json);
        }
        public Employee[] GetAllEmployees()
        {
            return context.Employees.ToArray();
        }

        public Employee GetEmployeeById(int id)
        {
            return context.Employees.Single(o => o.Id == id);
        }

        public void AddCompany(Company company)
        {
            context.Companies.Add(company);
            context.SaveChanges();
        }

        public Company[] GetAllCompanies()
        {
            return context.Companies.ToArray();
        }

        public Company GetCompanyById(int id)
        {
            return context.Companies.Single(o => o.Id == id);
        }
    }
}
