using Microsoft.AspNetCore.Mvc;
using tech_store_api.Application.Services;
using tech_store_api.Domain.Entities;

namespace tech_store_api.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FornecedorController : ControllerBase
    {
        private readonly FornecedorService _service;

        public FornecedorController(FornecedorService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var fornecedores = _service.ObterFornecedores();
            return Ok(fornecedores);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Fornecedor fornecedor)
        {
            if (fornecedor == null)
                return BadRequest("Fornecedor inválido.");
            var novoFornecedor = _service.CriarFornecedor(fornecedor);

            return CreatedAtAction(nameof(Get), new { id = novoFornecedor.Id }, novoFornecedor);
        }



        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var fornecedor = _service.ObterFornecedorPorId(id);
            if (fornecedor == null)
                return NotFound();

            _service.RemoverFornecedor(id);

            return NoContent();
        }
    }
}
