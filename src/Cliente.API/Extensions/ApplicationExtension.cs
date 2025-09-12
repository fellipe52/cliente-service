using Application;
using Application.Interfaces;
using Domain.Notification;
namespace Cliente.API.Extensions
{
    public static class ApplicationExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IClienteApplication, ClienteApplication>();

            services.AddScoped<NotificationContext>();

            return services;
        }
    }
}