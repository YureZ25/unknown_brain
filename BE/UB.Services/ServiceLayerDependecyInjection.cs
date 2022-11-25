using Microsoft.Extensions.DependencyInjection;
using UB.Services.Interfaces;
using UB.Services.Services;

namespace UB.Services
{
    public static class ServiceLayerDependecyInjection
    {
        public static void AddServiceLayerDI(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(ServiceLayerDependecyInjection));

            services.AddScoped<IUserService, UserService>();
        }
    }
}
