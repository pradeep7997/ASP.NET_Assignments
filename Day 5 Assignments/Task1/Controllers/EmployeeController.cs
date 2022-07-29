using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using Swashbuckle.AspNetCore.SwaggerUI;
using Microsoft.AspNetCore.Http;
using WebApplication5.Repository;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    [Route("api/Employee")]
    [ApiController]

    public class EmployeeController : ControllerBase
    {
        EmployeeRepo _repo;
        public EmployeeController(EmployeeRepo repo)
        {
            _repo = repo;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAllEmpDetails()
        {

            var Elist = _repo.GetAllDetails();

            return Ok(Elist);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmpDetailsByID(int id)
        {
            var Eobj = _repo.GetDetailsByID(id);
            if(Eobj!=null)
            {
                return Ok(Eobj);
            }
            else
            {
                return NotFound("Employee ID Doesn't Exist");
            }
        }


        [HttpPost]
        public async Task<IActionResult> Create(Employee obj)
        {

            _repo.AddEmp(obj);
            return Ok("Employee Details Added");
        }

        [HttpPut]
        public async Task<IActionResult> Edit(int id)
        {
                Employee obj = await _repo.GetDetailsByID(id);
                _repo.UpdateEmp(obj);
            return Ok("Employee Details are Edited");
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            Employee obj = await _repo.GetDetailsByID(id);
            _repo.DeleteEmp(id);
            return Ok("Employee Details are Deleted");
        }

        

    }
}
