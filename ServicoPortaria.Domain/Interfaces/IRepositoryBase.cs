using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicoPortaria.Domain.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        // Dito as regras de Utilização de cada coisa.
        void Inserir(TEntity obj);
        TEntity ConsultarPorId(int id); 
        IEnumerable<TEntity> ConsultarComFiltros(object obj, object obj2);
        IEnumerable<TEntity> ConsultarTodos();
        void Update(TEntity obj);
        void Remove(TEntity obj);
    }
}
