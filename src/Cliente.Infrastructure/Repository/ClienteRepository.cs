using Cliente.Domain.Interfaces.Repository;
using Cliente.Infrastructure.Data;

namespace Cliente.Infrastructure.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ClienteContext _context;

        public ClienteRepository(ClienteContext context)
        {
            _context = context;
        }

        public async Task<Guid> CriarClienteAsync(Domain.Entities.Clientes cliente)
        {
            var result = await _context.Clientes.AddAsync(cliente);
            await _context.SaveChangesAsync();
            return result.Entity.Id;
        }
    }
}