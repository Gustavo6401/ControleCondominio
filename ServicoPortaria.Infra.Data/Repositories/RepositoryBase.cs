using System;
using System.Linq;
using System.Collections.Generic;
using ServicoPortaria.Domain.Interfaces;
using ServicoPortaria.Infra.Data.Contexto;

namespace ServicoPortaria.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected PortariaContext Db = new PortariaContext();
        public IEnumerable<TEntity> ConsultarComFiltros(object obj, object obj2)
        {
            throw new NotImplementedException();
        }

        public TEntity ConsultarPorId(int id)
        {
            return Db.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ConsultarTodos()
        {
            return Db.Set<TEntity>().ToList();
        }

        public void Disponse()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Inserir(TEntity obj)
        {
            Db.Set<TEntity>().Add(obj);

            Db.SaveChanges();
        }

        public void Remove(TEntity obj)
        {
            Db.Set<TEntity>().Remove(obj);

            Db.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            Db.SetModified(obj);

            Db.SaveChanges();
        }
    }
}
