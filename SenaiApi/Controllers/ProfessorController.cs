using Microsoft.AspNetCore.Mvc;
using SenaiApi.Dtos;
using SenaiApi.Servicos;
using SenaiApi.Servicos.Interfaces;

namespace SenaiApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProfessorController : Controller
    {
        private readonly IProfessorService _professorService;
        public ProfessorController(IProfessorService professorService)
        {
            _professorService = professorService;
        }

        [HttpPost]
        [Route("Salvar")]
        public IActionResult Adicionar(SalvarProfessorDto professorDto)
        {
            _professorService.SalvarProfessor(professorDto);
            return Ok();
        }

        [HttpGet]
        [Route("Buscar")]
        public IActionResult BuscarTodos()
        {
            var professor = _professorService.BuscarTodos();
            return Ok(professor);
        }

        [HttpDelete]
        [Route("Deletar")]
        public IActionResult DeletarProfessor(long id)
        {
            _professorService.Remover(id);
            return Ok();
        }
        [HttpPost]
        [Route("Editar")]
        public IActionResult Editar([FromBody] ProfessorDto professorDto)
        {
            _professorService.Editar(professorDto);
            return Ok();
        }

    }
}
