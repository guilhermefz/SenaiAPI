using SenaiApi.Dtos;

namespace SenaiApi.Servicos.Interfaces
{
    public interface IEnderecoServices
    {
        void SalvarEndereco(EnderecoDtoSalvar enderecoDto);
        List<EnderecoDto> BuscarEnderecos();
        void Remover(long id);
        void Editar(EnderecoDto model);


    }
}
