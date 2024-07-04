using Domain.DtoModel;
using Domain.EmployeeEntity;
using Repositroy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastrcture.EmployeeSys.EmployeeRepo
{
    public interface IEmployee : IRepository<Employee>
    {

    }
}
