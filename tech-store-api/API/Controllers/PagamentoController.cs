using Microsoft.AspNetCore.Mvc;
using tech_store_api.Application.Services;
using tech_store_api.Domain.Entities;

namespace tech_store_api.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PagamentoController : ControllerBase
    {
        private readonly PagamentoService _service;

        public PagamentoController(PagamentoService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var pagamentos = _service.ObterPagamentos();
            return Ok(pagamentos);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Pagamento pagamento)
        {
            if (pagamento == null)
                return BadRequest("Pagamento inválido.");
            var novoPagamento = _service.CriarPagamento(pagamento);

            return CreatedAtAction(nameof(Get), new { id = novoPagamento.Id }, novoPagamento);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var pagamento = _service.ObterPagamentoPorId(id);
            if (pagamento == null)
                return NotFound();

            _service.RemoverPagamento(id);

            return NoContent();
        }
    }
}
