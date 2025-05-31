using SenaiApi.Entidades;

namespace SenaiApi.Dtos
{
    public class ExibirEscolaDto
    {
        public string Nome { get; set; }
        public long Id { get; set; }
        public EnderecoDto Endereco { get; set; }
        public List<ProfessorDto> professores { get; set; }
    }
}
