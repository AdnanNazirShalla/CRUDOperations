using AutoMapper;
using CRUDinMVC.Application.RRModels;
using CRUDinMVC.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDinMVC.Application.Mapper
{
    public sealed class User:Profile
    {
        public User() 
        {
            CreateMap<EmployeeRequest, Employees>();
            CreateMap<Employees, EmployeeResponse>();
            CreateMap<EmployeeResponse, Employees>();
        }
    }
}
