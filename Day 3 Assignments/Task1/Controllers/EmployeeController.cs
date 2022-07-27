using Microsoft.AspNetCore.Mvc;
using WebApplication3.Repository;
using WebApplication3.Models;
namespace WebApplication3.Controllers
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
