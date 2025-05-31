using SenaiApi.Dtos;

namespace SenaiApi.Servicos.Interfaces
{
    public interface IProfessorService
    {
        void SalvarProfessor(SalvarProfessorDto salvarProfessorDto);
        List<ProfessorDto> BuscarTodos();
        void Remover(long id);
        void Editar(ProfessorDto model);
    }
}
