using CRUDinMVC.Application.Abstractions.IServices;
using CRUDinMVC.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace CRUDinMVC.Application
{
    public static class AssemblyRefrence
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IEmployeeService, EmployeeServices>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}