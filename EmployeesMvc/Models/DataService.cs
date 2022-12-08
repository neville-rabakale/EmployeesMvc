namespace EmployeesMvc.Models
{
    public class DataService
    {
        static List<Employee> Employees = new List<Employee>
        { 
            new Employee { Id = 0, Name= "Jon", Email = "jon@gmail.com"},
        };

        public void AddEmployee(Employee employee)
        {
            employee.Id = Employees.Max(x => x.Id) + 1;
            Employees.Add(employee);
        }
        public Employee[] GetAllEmployees()
        {
            return Employees.ToArray();
        }

        public Employee GetEmployeeById(int id)
        {
            return Employees.Single(o => o.Id == id);
        }
    }
}
