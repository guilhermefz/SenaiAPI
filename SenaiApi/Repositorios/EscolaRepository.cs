using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using SenaiApi.Contexto;
using SenaiApi.Dtos;
using SenaiApi.Entidades;
using SenaiApi.Servicos.Interfaces;

namespace SenaiApi.Repositorios
{
    public class EscolaRepository : IEscolaRepository
    {
        private readonly SenaiContext _context;
        private readonly object _escolarepository;

        public EscolaRepository(SenaiContext context)
        {
            _context = context;
        }
        public void Salvar(Escola escola)
        {
            if(escola.Id == 0)
                _context.Escola.Add(escola);
        else
                _context.Escola.Update(escola);

            _context.SaveChanges();
        }

        public List<Escola> PegarTodos()
        {
            return _context.Escola.ToList();
        }
        public async Task Remover(long id)
        {
            await _context.Escola.Where(c => c.Id == id).ExecuteDeleteAsync();
        }

        public Escola ObterPorId(long id)
        {
            return _context.Escola.FirstOrDefault(e => e.Id == id);
        }
       
    }
}
