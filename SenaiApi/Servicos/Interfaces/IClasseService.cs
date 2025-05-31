using SenaiApi.Dtos;

namespace SenaiApi.Servicos.Interfaces
{
    public interface IClasseService
    {
        void Salvar(ClasseDto classeDto);
        List<ClasseDto> ObterTodos();
    }
}
