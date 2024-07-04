using Domain.EmployeeEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtintionLayer.EmployeeExtintions
{
    public static class EmployeeHelper
    {
        public static bool EmployeeNullChecker(this Employee employee) 
        { 
            if (employee is null)
                return false;
            return true;       
        }
    }
}
