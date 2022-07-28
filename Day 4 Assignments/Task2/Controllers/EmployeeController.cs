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
        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;
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
            _logger.LogInformation("GetEmpbyDepid Action is Processed.");
           List<Employee> deplist = _repo.GetDetailsByDeptID(depid);
            return RedirectToAction("GetEmpbyDepid");
        }
        [HttpGet]
        public IActionResult GetEmpbyJob()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GetEmpbyJob(string job)
        {
            _logger.LogInformation("GetEmpbyJob Action is Processed.");

            List<Employee> joblist = _repo.GetDetailsByJob(job);
            return RedirectToAction("GetEmpbyJob");
        }
        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee obj)
        {
            _logger.LogInformation("Employee Creation Action is Processed.");

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
            _logger.LogInformation("Employee Details Edited");

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
            _logger.LogInformation("Deletion Action is done");

            _repo.DeleteEmp(id);
            return RedirectToAction("Index");
        }

    }
}
