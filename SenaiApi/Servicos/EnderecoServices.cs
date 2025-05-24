using AutoMapper;
using SenaiApi.Dtos;
using SenaiApi.Entidades;
using SenaiApi.Servicos.Interfaces;

namespace SenaiApi.Servicos
{
    public class EnderecoServices : IEnderecoServices
    {
        private readonly IMapper _mapper;
        private readonly IEnderecoRepository _enderecoRepository;

        public EnderecoServices(IMapper mapper, IEnderecoRepository enderecoRepository)
        {
            _mapper = mapper;
            _enderecoRepository = enderecoRepository;
        }   

        public void SalvarEndereco (EnderecoDtoSalvar enderecoDto)
        {
            var endereco = _mapper.Map<Endereco>(enderecoDto);
            _enderecoRepository.SalvarEndereco(endereco);
        }

        public List<EnderecoDto> BuscarEnderecos()
        {
            var enderecos =  _enderecoRepository.PegarEnderecos();
            return _mapper.Map<List<EnderecoDto>>(enderecos);
        }

        public void Remover(long id)
        {
            _enderecoRepository.Remover(id);
        }

        public void Editar(EnderecoDto model)
        {
            var endereco = _enderecoRepository.ObterPorId(model.Id);
            _mapper.Map(model, endereco);
            _enderecoRepository.SalvarEndereco(endereco);
        }
    }
}
