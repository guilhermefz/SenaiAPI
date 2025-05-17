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

        public List<EscolaDto> BuscarTodos()
        {
            var escolas = _escolaRepository.PegarTodos();
            return _mapper.Map<List<EscolaDto>>(escolas);
        }
    }
}
