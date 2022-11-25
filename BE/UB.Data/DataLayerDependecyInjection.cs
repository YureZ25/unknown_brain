using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UB.Data.Repositories;
using UB.Data.Repositories.Interfaces;
using UB.Data.UnitOfWork;

namespace UB.Data
{
    public static class DataLayerDependecyInjection
    {
        public static void AddDataLayerDI(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(opt =>
                opt.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

            services.AddTransient<IUoW, UoW>();

            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<GradeRepository>();
        }
    }
}
