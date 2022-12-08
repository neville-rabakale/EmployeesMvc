using System.ComponentModel.DataAnnotations;

namespace EmployeesMvc.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name="Enter Email")]
        public string Email { get; set; }
    }
}
