using SenaiApi.Entidades;

namespace SenaiApi.Servicos.Interfaces
{
    public interface IProfessorRepository
    {
        void SalvarProfessor(Professor professor);
        List<Professor> PegarTodos();
        void Remover(long professorId);
        Professor ObterPorId(long Id);
    }
}
