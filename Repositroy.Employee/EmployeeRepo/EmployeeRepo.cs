
using Domain.Data;
using Domain.DtoModel;
using Domain.EmployeeEntity;
using Microsoft.EntityFrameworkCore;
using Repositroy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastrcture.EmployeeSys.EmployeeRepo
{
  public  class EmployeeRepo : Repository<Employee>,IEmployee
    {

        public EmployeeRepo(EmpMangementSysContext context):base(context)
        {
            
        }
    }
}
