using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface  IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees(bool trackChanges);
        //bool CreateEmployee(Employee Employee);
        //bool UpdateEmployee(Employee Employee);
        //bool DeleteEmployee(Employee Employee);
    }

}
