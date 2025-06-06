using Microsoft.EntityFrameworkCore;
using SenaiApi.Contexto;
using SenaiApi.Entidades;
using SenaiApi.Servicos.Interfaces;

namespace SenaiApi.Repositorios
{
    public class ProfessorRepository  : BaseRepository<Professor> , IProfessorRepository
    {
        private readonly SenaiContext _context;
        public ProfessorRepository(SenaiContext context) : base(context) 
        {
            _context = context;
        }

        public void SalvarProfessor(Professor professor)
        {
            base.Salvar(professor);
        }
        public List<Professor> PegarTodos()
        {
            return base.ObterTodos().ToList();
            //return _context.Professor.ToList();
        }

        public void Remover(long professorId)
        {
            _context.Professor.Where(c => c.Id == professorId).ExecuteDelete();
        }
        public Professor ObterPorId(long Id)
        {
            return _context.Professor.FirstOrDefault(c => c.Id == Id);

        }
    }
}
