using SenaiApi.Contexto;
using SenaiApi.Entidades;
using SenaiApi.Servicos.Interfaces;

namespace SenaiApi.Repositorios
{
    public class ClasseRepository : BaseRepository<Classe> , IClasseRepository
    {
        private readonly SenaiContext _context;

        ClasseRepository(SenaiContext context) : base(context)
        {
            _context = context;
        }
        public void Salvar(Classe classe)
        {
            if (classe.Id == 0)
                _context.Classe.Add(classe);
            else
                _context.Classe.Update(classe);

            _context.SaveChanges();
        }

        public List<Classe> ObterTodos()
        {
            return base.ObterTodos().ToList();
        }
        
        
    }
}
