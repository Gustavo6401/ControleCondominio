using ServicoPortaria.Domain.Enttities;
using ServicoPortaria.Domain.Interfaces;
using System.Collections.Generic;

namespace ServicoPortaria.Infra.Data.Repositories
{
    public class CondominioRepository : RepositoryBase<Condominio>, ICondominioRepository
    {
        public IEnumerable<Condominio> BuscarPorCEP(string cep)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Condominio> BuscarPorCodPostal(string codPostal)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Condominio> BuscarPorNome(string nome)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Condominio> BuscarPorNumero(int numero)
        {
            throw new System.NotImplementedException();
        }
    }
}
