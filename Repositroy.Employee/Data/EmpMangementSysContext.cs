using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.EmployeeEntity;


namespace Domain.Data
{
    public class EmpMangementSysContext : DbContext
    {

        public EmpMangementSysContext(DbContextOptions<EmpMangementSysContext> options) : base(options)
        {
           
        }
        DbSet<EmployeeEntity.Employee> TblEmps{get;set;}
    }
}
