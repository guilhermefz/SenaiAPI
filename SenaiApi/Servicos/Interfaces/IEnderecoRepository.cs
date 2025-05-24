using SenaiApi.Entidades;

namespace SenaiApi.Servicos.Interfaces
{
    public interface IEnderecoRepository
    {
        void SalvarEndereco(Endereco endereco);
        List<Endereco> PegarEnderecos();
        void Remover(long id);
        Endereco ObterPorId(long id);
    }
}
