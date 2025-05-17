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

        [HttpPost("Adicionar")]
        public IActionResult Adicionar(EscolaDto escola)
        {
            _escolaService.Salvar(escola);
            return Ok();
        }

        [HttpGet("BuscarTodos")]
        public IActionResult BuscarTodos()
        {
            var escola = _escolaService.BuscarTodos();
            return Ok(escola);
        }
    }
}
