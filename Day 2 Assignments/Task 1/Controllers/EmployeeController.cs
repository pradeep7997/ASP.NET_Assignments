using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class EmployeeController : Controller
    {
        DbManager context = new DbManager();
        public IActionResult Index()
        {
            List<Employee> employees = context.GetAllDetails();
            return View(employees);
        }
        [HttpGet]
        public IActionResult Create()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee E)
        {
            if(ModelState.IsValid==true)
            {
                context.AddEmp(E);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Requesttype = Request.Method;
                ViewBag.ErrorMessage = "Invalid Details";
                return View();
            }

        }
        public IActionResult Details(int id)
        {
            Employee e1 =context.GetDetailsByID(id);
            return View(e1);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Employee e1 = context.GetDetailsByID(id);
            return View(e1);
        }
        [HttpPost]
        public IActionResult Edit(Employee e1)
        {
            if (ModelState.IsValid == true)
            {
                context.UpdateEmp(e1);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Requesttype = Request.Method;
                ViewBag.ErrorMessage = "Invalid Details";
                return View();
            }

        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Employee e1 = context.GetDetailsByID(id);
            return View(e1);
        }
        [HttpPost]
        public IActionResult DeleteConfirm(int id)
        {
            context.DeleteEmp(id);
            return RedirectToAction("Index");

        }

    }
}
