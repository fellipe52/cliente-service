using System.Net;
using Application.Interfaces;
using Cliente.Domain.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Cliente.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly ILogger<ClienteController> _logger;

        private readonly IClienteApplication _clienteApplication;

        public ClienteController(ILogger<ClienteController> logger, IClienteApplication clienteApplication)
        {
            _logger = logger;
            _clienteApplication = clienteApplication;
        }

        [HttpPost("")]
        [ProducesResponseType(typeof(Guid), (int)HttpStatusCode.Created)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> CriarClienteApplicationAsync([FromBody] ClienteDTO request)
        {
            var response = await _clienteApplication.CriarClienteApplicationAsync(request);

            return Ok(response);
        }
    }
}