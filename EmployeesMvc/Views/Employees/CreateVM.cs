using System.ComponentModel.DataAnnotations;

namespace EmployeesMvc.Views.Employees
{
    public class CreateVM
    {
        [Required(ErrorMessage ="Enter Name")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Enter email")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Enter bot check")]
        [Range(4,4, ErrorMessage ="The answer is incorrect, please try again")]
        public int? BotCheck { get; set; }
    }
}
