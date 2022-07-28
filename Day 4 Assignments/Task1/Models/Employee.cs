using Microsoft.EntityFrameworkCore;
namespace WebApplication4.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
        public string? EmployeeJob { get; set; }
        public int EmployeeSalary { get; set; }
        public int EmployeeDeptno { get; set; }


    }
    public class EmployeeDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options):base(options)
        {

        }
    }


}
