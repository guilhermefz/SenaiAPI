using Microsoft.EntityFrameworkCore;
using SenaiApi.Contexto;
using SenaiApi.Dtos;
using SenaiApi.Entidades;
using SenaiApi.Servicos.Interfaces;

namespace SenaiApi.Repositorios
{
    public class EnderecoRepository : BaseRepository<Endereco> , IEnderecoRepository
    {
        private readonly SenaiContext _context;

        public EnderecoRepository(SenaiContext context) : base(context) 
        {
            _context = context;
        }

        public void SalvarEndereco(Endereco endereco)
        {
            base.Salvar(endereco);
        }

        public List<Endereco> PegarEnderecos()
        {
            return base.ObterTodos().ToList();
            //return _context.Endereco.ToList();
        }

        public void Remover(long enderecoId)
        {
            _context.Endereco.Where(c => c.Id == enderecoId).ExecuteDelete();
        }

        public Endereco ObterPorId(long id)
        {
            return _context.Endereco.FirstOrDefault(e => e.Id == id);
        }

       
    }
}
