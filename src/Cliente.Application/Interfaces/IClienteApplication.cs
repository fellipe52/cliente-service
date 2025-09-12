using Cliente.Domain.DTOs;

namespace Application.Interfaces
{
    public interface IClienteApplication
    {
        public Task<Guid> CriarClienteApplicationAsync(ClienteDTO request);
    }
}