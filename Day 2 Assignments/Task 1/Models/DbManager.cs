namespace WebApplication2.Models
{
    public class DbManager
    {
        List<Employee> Elist = new List<Employee>();
        public DbManager()
        {
            Elist = new List<Employee>()
            {
                new Employee(){EmployeeId=1,EmployeeName="Pradeep",EmployeeJob="IT Trainee",EmployeeeSalary=1000,DepartmentNo=1001},
                new Employee(){EmployeeId=2,EmployeeName="Monish",EmployeeJob="Manager",EmployeeeSalary=100000,DepartmentNo=1002},
                new Employee(){EmployeeId=3,EmployeeName="Vivek",EmployeeJob="Team Lead",EmployeeeSalary=120000,DepartmentNo=1003},
                new Employee(){EmployeeId=4,EmployeeName="Vamsi",EmployeeJob="SDE",EmployeeeSalary=103000,DepartmentNo=1004}

            };

        }

        public List<Employee> GetAllDetails()
        {
            return Elist;
        }

        public void AddEmp(Employee e1)
        {
             Elist.Add(e1);
        }
        public Employee GetDetailsByID(int id)
        {
            return Elist.Find(item => item.EmployeeId == id);
        }
        public void DeleteEmp(int id)
        {
            Employee e1=Elist.Find(item => item.EmployeeId == id);
               Elist.Remove(e1);
        }
        public void UpdateEmp(Employee updatedobj)
        {
            Employee oldobj=Elist.Find(item => item.EmployeeId==updatedobj.EmployeeId);
            Elist.Remove(oldobj);
            Elist.Add(updatedobj);
        }
    }
}
