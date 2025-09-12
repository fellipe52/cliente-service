using Cliente.Domain.DTOs;
using Cliente.Domain.UseCases;
using Cliente.Domain.Validators;
using FluentValidation;
using Cliente.Domain.Interfaces.UseCase;

namespace Cliente.API.Extensions
{
    public static class DomainExtensions
    {
        public static IServiceCollection AddDomainServices(this IServiceCollection services)
        {
            services.AddScoped<IValidator<ClienteDTO>, ClienteDTOValidator>();

            services.AddScoped<IClienteUseCase, ClienteUseCase>();

            return services;
        }
    }
}