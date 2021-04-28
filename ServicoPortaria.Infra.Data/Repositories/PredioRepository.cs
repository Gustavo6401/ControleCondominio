using ServicoPortaria.Domain.Enttities;
using ServicoPortaria.Domain.Interfaces;
using System.Collections.Generic;

namespace ServicoPortaria.Infra.Data.Repositories
{
    public class PredioRepository : RepositoryBase<Predio>, IPredioRepository
    {
        public IEnumerable<Predio> BuscarPorCondominio(string nome)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Predio> BuscarPorNome(string nome)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Predio> BuscarPorNumero(int numero)
        {
            throw new System.NotImplementedException();
        }
    }
}
