using WebApplication4.Models;
namespace WebApplication4.Repository
{
    public interface IEmployeeRepo
    {
        public List<Models.Employee> GetAllDetails();
        public Models.Employee GetDetailsByID(int id);
        public List<Models.Employee> GetDetailsByDeptID(int depid);
        public List<Models.Employee> GetDetailsByJob(string depid);

        public void AddEmp(Models.Employee obj);
        public void EditEmp(Models.Employee e1);
        public void DeleteEmp(int id);
        public void UpdateEmp(Models.Employee obj);

    }
}
