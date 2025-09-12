using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Domain.Interfaces.Repository
{
    public interface IClienteRepository
    {
        public Task<Guid> CriarClienteAsync(Domain.Entities.Clientes cliente);
    }
}