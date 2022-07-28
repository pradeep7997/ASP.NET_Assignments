using WebApplication4.Models;
namespace WebApplication4.Repository
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
        public List<Employee> GetDetailsByDeptID(int depid)
        {
            List<Employee> DepList = new List<Employee>();
            foreach (Employee item in _context.Employees)
            {
                if(item.EmployeeDeptno==depid)
                {
                    Employee e1 = item;
                    DepList.Add(e1);
                }
            }
            return DepList;
        }
        public List<Employee> GetDetailsByJob(string job)
        {
            List<Employee> JobList = new List<Employee>();
            foreach (Employee item in _context.Employees)
            {
                if (item.EmployeeJob == job)
                {
                    Employee e1 = item;
                    JobList.Add(e1);
                }
            }
            return JobList;
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
