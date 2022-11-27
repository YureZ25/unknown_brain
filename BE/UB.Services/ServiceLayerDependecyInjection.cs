using Microsoft.Extensions.DependencyInjection;
using UB.Services.Interfaces;
using UB.Services.Services;
using UB.Services.Services.Interfaces;

namespace UB.Services
{
    public static class ServiceLayerDependecyInjection
    {
        public static void AddServiceLayerDI(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(ServiceLayerDependecyInjection));

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IGradeService, GradeService>();
            services.AddScoped<ISpecializationService, SpecializationService>();
            services.AddScoped<IWelcomeFormService, WelcomeFormService>();
            services.AddScoped<IRecomendationService, RecomendationService>();
        }
    }
}
