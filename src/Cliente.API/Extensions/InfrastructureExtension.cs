using Cliente.Domain.DTOs;
using Cliente.Domain.UseCases;
using Cliente.Domain.Validators;
using FluentValidation;
using Cliente.Domain.Interfaces.UseCase;
using Cliente.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Cliente.Domain.Interfaces.Repository;
using Cliente.Infrastructure.Repository;

namespace Cliente.API.Extensions
{
    public static class InfrastructureExtension
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<ClienteContext>(options =>
                options.UseNpgsql(connectionString));

            services.AddScoped<IValidator<ClienteDTO>, ClienteDTOValidator>();

            services.AddScoped<IClienteRepository, ClienteRepository>();

            services.AddScoped<IClienteUseCase, ClienteUseCase>();

            return services;
        }
    }
}