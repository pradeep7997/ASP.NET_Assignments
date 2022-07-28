using Microsoft.AspNetCore.Mvc;
using WebApplication4.Repository;
using WebApplication4.Models;
namespace WebApplication4.Controllers
{
    public class EmployeeController : Controller
    {
        IEmployeeRepo _repo;
        public EmployeeController(IEmployeeRepo repo)
        {
            _repo = repo;
        }
        public IActionResult Index()
        {
            List<Employee> Elist=_repo.GetAllDetails();
            
            return View(Elist);
        }
        [HttpGet]
        public IActionResult GetEmpbyDepid()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GetEmpbyDepid(int depid)
        {
           List<Employee> deplist = _repo.GetDetailsByDeptID(depid);
            return View(deplist);
        }
        [HttpGet]
        public IActionResult GetEmpbyJob()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GetEmpbyJob(string job)
        {
            List<Employee> joblist = _repo.GetDetailsByJob(job);
            return View(joblist);
        }
        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee obj)
        {
            _repo.AddEmp(obj);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            Employee obj = _repo.GetDetailsByID(id);
            return View(obj);
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            Employee obj = _repo.GetDetailsByID(id);
            return View(obj);
        }

        [HttpPost]
        public IActionResult Edit(Employee obj)
        {
            _repo.UpdateEmp(obj);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            Employee obj = _repo.GetDetailsByID(id);
            return View(obj);
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteConfirm(int id)
        {
            _repo.DeleteEmp(id);
            return RedirectToAction("Index");
        }

    }
}
