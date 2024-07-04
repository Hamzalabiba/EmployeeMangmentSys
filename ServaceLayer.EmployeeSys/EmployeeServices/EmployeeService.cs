using Domain.DtoModel;
using Domain.EmployeeEntity;
using Repositroy.EmployeeSys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServaceLayer.EmployeeDtoSys.EmployeeDtoServices
{
    public class EmployeeService
    {
        private readonly IUnitOfWork _IUnitOfWork;

        public EmployeeService(IUnitOfWork iUnitOfWork)
        {
            _IUnitOfWork = iUnitOfWork;
        }

        public void DeleteEmployeeDto(EmployeeDto entity)
        {
            var employee = new Employee 
            {
            Id = entity.Id,
            };
            _IUnitOfWork.employeeRepo.Delete(employee);
            _IUnitOfWork.Complate();
        }

        public async Task<IEnumerable<Employee>> GetAll()
        {
            
            return _IUnitOfWork.employeeRepo.GetAll();
        }

        public Employee GetById(Guid Id)
        {
            return _IUnitOfWork.employeeRepo.GetById(Id);
        }

        public  void Insert(EmployeeDto entity)
        {
            var employee = new Employee
            {
                FirsName = entity.FirsName,
                MiddleName = entity.MiddleName,
                LastName = entity.LastName,
                Id = Guid.NewGuid(),
                CreatadDate = DateTime.Now,
                EmpNo = entity.EmpNo,
                Salary = entity.Salary,
                CreatedBy = entity.CreatedBy,
                DefaultDesc = entity.DefaultDesc,
                Postion =entity.Postion,
            };
            try
            {
                _IUnitOfWork.employeeRepo.Insert(employee);
                _IUnitOfWork.Complate();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public void Update(EmployeeDto entity)
        {
            var employee = new Employee { 
            FirsName= entity.FirsName,
            MiddleName= entity.MiddleName,
            LastName= entity.LastName,
            ModifiedBy = entity.ModifiedBy,
            ModifiedDate = DateTime.Now,
            Salary= entity.Salary,
            DefaultDesc = entity.DefaultDesc,
            };

            _IUnitOfWork.employeeRepo.Update(employee);
            _IUnitOfWork.Complate();
        }
    }
}
