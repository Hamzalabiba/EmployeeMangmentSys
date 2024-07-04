using System.ComponentModel.DataAnnotations;

namespace EmployeeSys.Web.Models
{
    public class EmployeeDto:BaseEntityDto
    {
        public string? FirsName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? EmpNo { get; set; }
        public decimal? Salary { get; set; }
        public string? Postion { get; set; }
    }
}
