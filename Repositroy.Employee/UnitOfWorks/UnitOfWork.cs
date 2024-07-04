using Domain.Data;
using Infrastrcture.EmployeeSys.EmployeeRepo;
using Microsoft.EntityFrameworkCore;
using Repositroy;
using Repositroy.EmployeeSys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructre.EmployeeSys
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EmpMangementSysContext _context;

        public IEmployee employeeRepo { get; set; }
        public UnitOfWork(EmpMangementSysContext Context)
        {
            _context = Context;
            employeeRepo = new EmployeeRepo(_context);
        }
        


        public int Complate()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
