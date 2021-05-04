using System.Collections.Generic;
using ServicoPortaria.Domain.Entities;

namespace ServicoPortaria.Domain.Interfaces
{
    public interface IGaragemRepository : IRepositoryBase<Garagem>
    {
        
        IEnumerable<Garagem> BuscarPorCondominio(int id);
        IEnumerable<Garagem> BuscarPorPredio(int id);
        IEnumerable<Garagem> BuscarPorNumero(int numero);
    }
}
