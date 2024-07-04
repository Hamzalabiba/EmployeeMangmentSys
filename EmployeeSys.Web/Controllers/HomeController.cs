
using EmployeeSys.Web.EmployeeExtintions;
using EmployeeSys.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.Http.Headers;

namespace EmployeeSys.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        const string path = "https://localhost:7167/Api/Employee";
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<EmployeeDto> employees = null;
            employees = await employees.Request(path, "/GetAllEmployee");
            return View(employees);
        }
        [HttpPost]
        public async Task<IActionResult> deleteEmployee([FromBody] Guid id)
        {
            EmployeeDto employee = new EmployeeDto { 
            Id = id,
            };
            
            if (id == Guid.Empty)
            {
                return BadRequest("Invalid employee Id.");
            }
            employee = await employee.request(path, $"/deleteEmployee");
            return Ok(employee);
        }

        public IActionResult InsertEmployee([FromBody] EmployeeDto employee) 
        {


            return View();
        }
    }
}
