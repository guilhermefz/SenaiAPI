using Microsoft.AspNetCore.Mvc;
using SenaiApi.Dtos;
using SenaiApi.Entidades;
using SenaiApi.Servicos.Interfaces;

namespace SenaiApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EscolaController : ControllerBase
    {
        private readonly IEscolaService _escolaService;
        public EscolaController(IEscolaService escolaservice) 
        {
            _escolaService = escolaservice;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok();
        }

        [HttpPost]
        [Route("Adicionar")]
        public IActionResult Adicionar(EscolaDto escola)
        {
            _escolaService.Salvar(escola);
            return Ok();
        }

        [HttpGet]
        [Route("BuscarTodos")]
        public IActionResult BuscarTodos()
        {
            var escola = _escolaService.BuscarTodos();
            return Ok(escola);
        }
        [HttpDelete]
        [Route("Remover")]
        public async Task<IActionResult> Remover(long id)
        {
            await _escolaService.Remover(id);
            return Ok();
        }

        [HttpPost]
        [Route("Editar")]
        public IActionResult Editar([FromBody] ExibirEscolaDto escola)
        {
            _escolaService.Editar(escola);
            return Ok();    
        }
        
    }
}
