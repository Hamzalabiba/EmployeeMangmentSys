using Infrastrcture.EmployeeSys.EmployeeRepo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositroy.EmployeeSys
{
    public interface IUnitOfWork : IDisposable
    {
        public IEmployee employeeRepo { get; }
        public int Complate();
    }
}
