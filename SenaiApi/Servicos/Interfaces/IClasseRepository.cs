using SenaiApi.Entidades;

namespace SenaiApi.Servicos.Interfaces
{
    public interface IClasseRepository
    {
        void Salvar(Classe classe);
        List<Classe> ObterTodos();
    }
}
