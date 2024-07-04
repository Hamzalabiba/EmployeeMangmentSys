using Domain.Employee;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.EmployeeEntity
{
    public class Employee : BaseEntity
    {
        [Required]
        public string? FirsName { get; set; }
        public string? MiddleName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        public string? EmpNo { get; set; }
        [Required]
        public decimal? Salary { get; set; }
        [Required]
        public string? Postion { get; set; }
        
    }
}

