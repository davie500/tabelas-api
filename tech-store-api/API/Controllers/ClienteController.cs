using Microsoft.AspNetCore.Mvc;
using tech_store_api.Application.Services;
using tech_store_api.Domain.Entities;

namespace tech_store_api.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly ClienteService _service;

        public ClienteController(ClienteService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var clientes = _service.ObterClientes();
            return Ok(clientes);
        }

        [HttpPost] 
        public IActionResult Post([FromBody] Cliente cliente)
        {
            if (cliente == null)
                return BadRequest("Cliente inválido.");
            var novoCliente = _service.CriarCliente(cliente);

            return CreatedAtAction(nameof(Get), new { id = novoCliente.Id }, novoCliente);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var cliente = _service.ObterClientePorId(id);
            if (cliente == null)
                return NotFound();

            _service.RemoverCliente(id);

            return NoContent();
        }
    }
}
