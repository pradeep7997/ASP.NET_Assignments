using WebApplication3.Models;
namespace WebApplication3.Repository
{
    public class EmployeeRepo:IEmployeeRepo
    {
        EmployeeDbContext _context;
        public EmployeeRepo(EmployeeDbContext context)
        {
            _context = context;
        }

        public List<Employee>  GetAllDetails()
        {
            List<Employee> employees = _context.Employees.ToList();
            return employees;
                
        }

        public Employee GetDetailsByID(int id)
        {
            Employee e1 = _context.Employees.Find(id);
            return e1;
        }

        public void AddEmp(Employee obj)
        {
            _context.Employees.Add(obj);
            _context.SaveChanges();
        }

        public void EditEmp(Employee e1)
        {
            _context.Employees.Update(e1);
            _context.SaveChanges();

        }

        public void DeleteEmp(int id)
        {
            Employee e1 = _context.Employees.Find(id);
            _context.Employees.Remove(e1);
            _context.SaveChanges();

        }

        public void UpdateEmp(Employee obj)
        {
            _context.Update(obj);
            _context.SaveChanges();
        }
    }
}
