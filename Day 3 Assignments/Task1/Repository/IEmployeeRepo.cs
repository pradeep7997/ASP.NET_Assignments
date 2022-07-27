using WebApplication3.Models;
namespace WebApplication3.Repository
{
    public interface IEmployeeRepo
    {
        public List<Models.Employee> GetAllDetails();
        public Models.Employee GetDetailsByID(int id);
        public void AddEmp(Models.Employee obj);
        public void EditEmp(Models.Employee e1);
        public void DeleteEmp(int id);
        public void UpdateEmp(Models.Employee obj);

    }
}
