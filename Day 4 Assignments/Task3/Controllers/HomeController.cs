using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication4.Models;
using WebApplication4.Filters;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [TypeFilter(typeof(MyExceptionFilter))]
        public IActionResult Index()
        {
            _logger.LogInformation("Index Action is Processed.");
            _logger.LogError("Error Message");
            _logger.LogWarning("Warning Message");


            List<Employee> Elist = new List<Employee>();
            Elist[1].EmployeeName = "Akula Pradeep";

            return View();
        }


        public IActionResult Index1()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}