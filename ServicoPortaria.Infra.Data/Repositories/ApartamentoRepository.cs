using System.Linq;
using ServicoPortaria.Domain.Enttities;
using ServicoPortaria.Domain.Interfaces;
using System.Collections.Generic;

namespace ServicoPortaria.Infra.Data.Repositories
{
    public class ApartamentoRepository : RepositoryBase<Apartamento>, IApartamentoRepository
    {
        public IEnumerable<Apartamento> BuscarPorCondominio(int id)
        {
            return Db.Apartamento.Where(p => p.IdCondominio == id);
        }

        public IEnumerable<Apartamento> BuscarPorMorador(int id)
        {
            return Db.Apartamento.Where(p => p.IdMorador == id);
        }
    }
}
