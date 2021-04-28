using System.Collections.Generic;
using ServicoPortaria.Domain.Enttities;

namespace ServicoPortaria.Domain.Interfaces
{
    public interface ICondominioRepository : IRepositoryBase<Condominio>
    {
        // Buscas feitas no banco de dados
        IEnumerable<Condominio> BuscarPorNome(string nome);
        IEnumerable<Condominio> BuscarPorCEP(string cep);
        IEnumerable<Condominio> BuscarPorCodPostal(string codPostal);
        IEnumerable<Condominio> BuscarPorNumero(int numero);
    }
}
