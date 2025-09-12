using Cliente.Domain.DTOs;

namespace Cliente.Domain.Interfaces.UseCase
{
    public interface IClienteUseCase
    {
        public Task<Guid> CriarClienteAsync(ClienteDTO request);
    }
}