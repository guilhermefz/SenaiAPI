using SenaiApi.Dtos;
using SenaiApi.Entidades;

namespace SenaiApi.Servicos.Interfaces
{
    public interface IEscolaService
    {
        void Salvar(EscolaDto escola);
        List<ExibirEscolaDto> BuscarTodos();

        Task Remover(long id);
        void Editar(ExibirEscolaDto model);
    }
}
