using Cliente.Domain.DTOs;
using FluentValidation;
using Cliente.Domain.Interfaces.UseCase;
using Cliente.Domain.Interfaces.Repository;

namespace Cliente.Domain.UseCases
{
    public class ClienteUseCase : IClienteUseCase
    {
        private readonly IValidator<ClienteDTO> _validator;
        private readonly IClienteRepository _clienteRepository;

        public ClienteUseCase(IValidator<ClienteDTO> validator, IClienteRepository clienteRepository)
        {
            _validator = validator;
            _clienteRepository = clienteRepository; 
        }

        public async Task<Guid> CriarClienteAsync(ClienteDTO request)
        {
            var response = Guid.Empty;

            var validationResult = await _validator.ValidateAsync(request);
            if (!validationResult.IsValid)
            {
                var mensagens = string.Join(" | ", validationResult.Errors.Select(e => e.ErrorMessage));

                response = Guid.Parse($"Erro ao criar cliente: {mensagens}");

                return response;
            }

            response = await _clienteRepository.CriarClienteAsync(new Entities.Clientes { Nome = request.Nome, Documento = request.Documento, Email = request.Email }); 

            return response;
        }
    }
}