using Microsoft.AspNetCore.Mvc;
using SenaiApi.Dtos;
using SenaiApi.Servicos.Interfaces;

namespace SenaiApi.Controllers
{
    public class EnderecoController : Controller
    {
        private readonly IEnderecoServices _enderecoServices;
        public EnderecoController(IEnderecoServices enderecoServices)
        {
            _enderecoServices = enderecoServices;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [Route("Salvar")]
        public IActionResult AdicionarEndereco([FromBody] EnderecoDtoSalvar enderecoDto)
        {
            _enderecoServices.SalvarEndereco(enderecoDto);
            return Ok();
        }

        [HttpGet]
        [Route("Listar")]
        public IActionResult MostrarEnderecos()
        {
            var enderecos = _enderecoServices.BuscarEnderecos();
            return Ok(enderecos);

        }

        [HttpDelete]
        [Route("Deletar")]
        public IActionResult DeletarEndereco(long id)
        {
            _enderecoServices.Remover(id);
            return Ok();
        }

        [HttpPost]
        [Route("Editar")]
        public IActionResult EditarEndereco([FromBody] EnderecoDto enderecoDto)
        {
            _enderecoServices.Editar(enderecoDto);
            return Ok();
        }

    }
}
