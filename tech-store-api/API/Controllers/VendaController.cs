//using Microsoft.AspNetCore.Mvc;
//using tech_store_api.Application.Services;
//using tech_store_api.Domain.Entities;

//namespace tech_store_api.API.Controllers
//{
//    [ApiController]
//    [Route("api/[controller]")]
//    public class VendaController : ControllerBase
//    {
//        private readonly VendaService _service;

//        public VendaController(VendaService service)
//        {
//            _service = service;
//        }

//        [HttpGet]
//        public IActionResult Get()
//        {
//            var vendas = _service.ObterVendas();
//            return Ok(vendas);
//        }

//        [HttpPost]
//        public IActionResult Post([FromBody] Venda venda)
//        {
//            if (venda == null)
//                return BadRequest("Venda inválida.");
//            var novoPagamento = _service.CriarVendas(venda);

//            return CreatedAtAction(nameof(Get), new { id = novoPagamento.Id }, novoPagamento);
//        }

//        [HttpDelete("{id}")]
//        public IActionResult Delete(int id)
//        {
//            var venda = _service.ObterVendasPorId(id);
//            if (venda == null)
//                return NotFound();

//            _service.RemoverVenda(id);

//            return NoContent();
//        }
//    }
//}
