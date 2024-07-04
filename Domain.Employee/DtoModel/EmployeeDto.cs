using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DtoModel
{
    public class EmployeeDto : BaseEntityDto
    {
        public string? FirsName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? EmpNo { get; set; }

        public decimal? Salary { get; set; }

        public string? Postion { get; set; }
    }
}
