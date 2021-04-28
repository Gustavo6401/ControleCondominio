using ServicoPortaria.Domain.Enttities;
using ServicoPortaria.Domain.Interfaces;
using System.Collections.Generic;

namespace ServicoPortaria.Infra.Data.Repositories
{
    public class ApartamentoRepository : RepositoryBase<Apartamento>, IApartamentoRepository
    {
        public IEnumerable<Apartamento> BuscarPorCondominio(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Apartamento> BuscarPorMorador(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
