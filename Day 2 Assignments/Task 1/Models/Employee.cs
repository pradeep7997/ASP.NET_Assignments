using System.ComponentModel.DataAnnotations;
namespace WebApplication2.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [Required]
        public string? EmployeeName { get; set; }
        public string? EmployeeJob { get; set; }
        public int EmployeeeSalary { get; set; }
        public int DepartmentNo { get; set; }
    }

}
