using CRUDinMVC.Application.RRModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDinMVC.Application.Abstractions.IServices
{
    public interface IEmployeeService
    {
        int AddEmployee(EmployeeRequest model);


        IEnumerable<EmployeeResponse> GetEmployees();


        int UpdateEmployee(EmployeeResponse model);


        int DeleteEmployee(Guid id); 

        EmployeeResponse GetEmployeeById(Guid id);
    }
}
