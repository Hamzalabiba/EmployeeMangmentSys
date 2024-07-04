using Domain.DtoModel;
using Domain.EmployeeEntity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using ServaceLayer.EmployeeDtoSys.EmployeeDtoServices;


namespace EmployeeMangmentSys.Controllers
{
   [Route("Api/[Controller]")]
   [ApiController]
    public class EmployeeController : Controller
    {
        private readonly EmployeeService _EmployeeService;

        public EmployeeController(EmployeeService employeeService)
        {
            _EmployeeService = employeeService;
        }
        [HttpGet(nameof(GetAllEmployee))]
        public  async Task<IEnumerable<Employee>> GetAllEmployee()
        {
            return  await _EmployeeService.GetAll();
        }

        [HttpGet(nameof(GetEmployeeById))]
        public  Employee GetEmployeeById(Guid id) 
        {
            return  _EmployeeService.GetById(id);
        }

        [HttpPost(nameof(deleteEmployee))]
        public IActionResult deleteEmployee([FromBody]EmployeeDto employee) 
        {
            if (employee is null) 
                return NotFound();
             _EmployeeService.DeleteEmployeeDto(employee);
              return Ok(employee);
        }

        [HttpPost(nameof(InsertEmployee))]
        public IActionResult InsertEmployee([FromBody] EmployeeDto employee) 
        {
            try
            {
                _EmployeeService.Insert(employee);
                return Ok(employee);
            }
            catch (Exception ex) 
            {
                return BadRequest();            
            }
        }

        [HttpPost(nameof(UpdateEmployee))]
        public IActionResult UpdateEmployee(EmployeeDto employee) 
        {
           if(employee is null)
                return NotFound($"Employee With This Id {employee.Id}");
            _EmployeeService.Update(employee);
            return Ok(employee);    
        }
    }
}
