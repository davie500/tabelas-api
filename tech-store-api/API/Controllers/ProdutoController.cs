using Microsoft.AspNetCore.Mvc;
using tech_store_api.Application.Services;
using tech_store_api.Domain.Entities;

namespace tech_store_api.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly ProdutoService _service;

        public ProdutoController(ProdutoService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var produtos = _service.ObterProdutos();
            return Ok(produtos);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Produto produto)
        {
            if (produto == null)
                return BadRequest("Produto inválido.");
            var novoProduto = _service.CriarProduto(produto);

            return CreatedAtAction(nameof(Get), new { id = novoProduto.Id }, novoProduto);
        }
    }
}
