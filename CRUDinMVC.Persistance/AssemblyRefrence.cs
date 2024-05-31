using CRUDinMVC.Application.Abstractions.IRepository;
using CRUDinMVC.Persistance.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CRUDinMVC.Persistance
{
    public static class AssemblyRefrence
    {
        public static IServiceCollection AddPersistanceServices(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContextPool<AppDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString(nameof(AppDbContext)));

            }

);
            services.AddScoped<IBaseRepository, BaseRepository>();
            return services;
        }
    }
}