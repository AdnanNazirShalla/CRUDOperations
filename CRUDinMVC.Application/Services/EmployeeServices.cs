using AutoMapper;
using CRUDinMVC.Application.Abstractions.IRepository;
using CRUDinMVC.Application.Abstractions.IServices;
using CRUDinMVC.Application.RRModels;
using CRUDinMVC.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDinMVC.Application.Services
{
    public class EmployeeServices : IEmployeeService
    {
        private readonly IBaseRepository repository;
        private readonly IMapper mapper;

        public EmployeeServices(IBaseRepository repository,IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public int AddEmployee(EmployeeRequest model)
        {
            Employees employee=mapper.Map<Employees>(model);
            employee.Id = Guid.NewGuid();

            if (repository.Add<Employees>(employee) > 0)
            {
                return 1;
            }
            return 0;
        }

        public int DeleteEmployee(Guid id)
        {
            Employees employee = repository.GetById<Employees>(id);

            if (employee != null)
            {
                if (repository.Delete<Employees>(employee) > 0)
                {
                    return 1;
                }
            }
            return 0;
        }

        public EmployeeResponse GetEmployeeById(Guid id)
        {
            return mapper.Map<EmployeeResponse>(repository.GetById<Employees>(id));
        }

        public IEnumerable<EmployeeResponse> GetEmployees()
        {
            return mapper.Map<List<EmployeeResponse>>(repository.GetAll<Employees>());
        }

        public int UpdateEmployee(EmployeeResponse model)
        {
            //Employees employee = repository.GetById<Employees>(model.Id);
            Employees employee = mapper.Map<Employees>(model);

            if (repository.Update<Employees>(employee) > 0)
            {
                return 1;
            }
            return 0;
        }
    }
}
