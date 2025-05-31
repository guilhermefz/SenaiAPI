using AutoMapper;
using SenaiApi.Dtos;
using SenaiApi.Entidades;
using SenaiApi.Servicos.Interfaces;

namespace SenaiApi.Servicos
{
    public class ProfessorService : IProfessorService
    {
        private readonly IProfessorRepository _professorRepository;
        private readonly IMapper _mapper;

        public ProfessorService(IMapper mapper, IProfessorRepository professorRepository)
        {
            _mapper = mapper;
            _professorRepository = professorRepository;
        }

        public void SalvarProfessor(SalvarProfessorDto salvarProfessorDto)
        {
            var professores = _mapper.Map<Professor>(salvarProfessorDto);
            _professorRepository.SalvarProfessor(professores);
        }

        public List<ProfessorDto> BuscarTodos()
        {
            var professores = _professorRepository.PegarTodos();
            return _mapper.Map<List<ProfessorDto>>(professores);
        }

        public void Remover(long id) 
        {
            _professorRepository.Remover(id);
        }

        public void Editar(ProfessorDto model)
        {
            var professores = _professorRepository.ObterPorId(model.Id);
            _mapper.Map(model, professores);
            _professorRepository.SalvarProfessor(professores);
        }
    }
}
