using AutoMapper;
using SenaiApi.Dtos;
using SenaiApi.Entidades;
using SenaiApi.Repositorios;
using SenaiApi.Servicos.Interfaces;

namespace SenaiApi.Servicos
{
    public class EscolaService : IEscolaService
    {
        private readonly IMapper _mapper;
        private readonly IEscolaRepository _escolaRepository;
       
        public EscolaService(IMapper mapper, IEscolaRepository escolarepository)
        {
            _mapper = mapper;
            _escolaRepository = escolarepository;
        }
        public void Salvar(EscolaDto escolaDto)
        {
            var escola = _mapper.Map<Escola>(escolaDto);
            _escolaRepository.Salvar(escola);
        }

        public List<ExibirEscolaDto> BuscarTodos()
        {
            var escolas = _escolaRepository.PegarTodos();
            return _mapper.Map<List<ExibirEscolaDto>>(escolas);
        }

        public async Task Remover(long id)
        {
            _escolaRepository.Remover(id);
        }


        public Escola ObterPorId(long id)
        {
            return _escolaRepository.ObterPorId(id);
        }
    }
}
