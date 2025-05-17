using SenaiApi.Dtos;
using SenaiApi.Entidades;

namespace SenaiApi.Servicos.Interfaces
{
    public interface IEscolaRepository
    {
        void Salvar(Escola escola);
        List<Escola> PegarTodos();
    }
}
