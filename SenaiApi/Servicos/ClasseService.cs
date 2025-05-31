using AutoMapper;
using SenaiApi.Dtos;
using SenaiApi.Entidades;
using SenaiApi.Repositorios;
using SenaiApi.Servicos.Interfaces;

namespace SenaiApi.Servicos
{
    public class ClasseService : IClasseService
    {
        private readonly IMapper _mapper;
        private readonly IClasseRepository _classeRepository;

        public ClasseService (IMapper mapper, IClasseRepository classeRepository)
        {
            _mapper = mapper;
            _classeRepository = classeRepository;
        }

        public void Salvar(ClasseDto classeDto)
        {
            var classes = _mapper.Map<Classe>(classeDto);
            _classeRepository.Salvar(classes);
        }

        public List<ClasseDto> ObterTodos()
        {
            var classes = _classeRepository.ObterTodos();
            return _mapper.Map<List<ClasseDto>>(classes);
        }
    }
}
