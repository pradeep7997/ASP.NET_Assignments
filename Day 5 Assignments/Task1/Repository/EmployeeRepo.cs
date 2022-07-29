using Microsoft.EntityFrameworkCore;
using WebApplication5.Models;
namespace WebApplication5.Repository
{
    public class EmployeeRepo
    {
        EmployeeDbContext _context;
        public EmployeeRepo(EmployeeDbContext context)
        {
            _context = context;
        }

         public async Task<List<Employee>> GetAllDetails()
        {
            List<Employee> employees = await _context.Employees.ToListAsync();
            return employees;
                
        }

        public async Task<Employee> GetDetailsByID(int id)
        {
            Employee e1 = await _context.Employees.FindAsync(id);
            return e1;
        }
        

        public async void AddEmp(Employee obj)
        {
            _context.Employees.AddAsync(obj);
            _context.SaveChangesAsync();
        }

        public async void EditEmp(Employee e1)
        {
            _context.Employees.Update(e1);
            _context.SaveChangesAsync();

        }

        public async void DeleteEmp(int id)
        {
            Employee e1 = await _context.Employees.FindAsync(id);
            _context.Employees.Remove(e1);
            _context.SaveChangesAsync();

        }

        public async void UpdateEmp(Employee obj)
        {
            _context.Update(obj);
            _context.SaveChangesAsync();
        }

       
    }
}
