using Application.Interfaces;
using Cliente.Domain.DTOs;
using Cliente.Domain.Interfaces.UseCase;

namespace Application
{
    public class ClienteApplication : IClienteApplication
    {
        private readonly IClienteUseCase _clienteUseCase;
        public ClienteApplication(IClienteUseCase clienteUseCase)
        {
            _clienteUseCase = clienteUseCase;
        }

        public async Task<Guid> CriarClienteApplicationAsync(ClienteDTO request)
        {
            return await _clienteUseCase.CriarClienteAsync(request);
        }
    }
}