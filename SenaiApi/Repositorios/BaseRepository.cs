﻿using Microsoft.EntityFrameworkCore;
using SenaiApi.Contexto;
using SenaiApi.Entidades;
using SenaiApi.Servicos.Interfaces;

namespace SenaiApi.Repositorios
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly SenaiContext _context;
        protected readonly DbSet<T> _dbSet;

        public BaseRepository(SenaiContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }
        public IQueryable<T> ObterTodos()
        {
            return _dbSet;
        }

        public void Salvar(T entidade)
        {
            if(entidade.Id == 0)
                _dbSet.Add(entidade);
            else 
                _dbSet.Update(entidade);

            _context.SaveChanges();
        }
    }
}
