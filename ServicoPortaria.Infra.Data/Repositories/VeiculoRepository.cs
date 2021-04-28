using System.Linq;
using ServicoPortaria.Domain.Enttities;
using ServicoPortaria.Domain.Interfaces;
using System.Collections.Generic;

namespace ServicoPortaria.Infra.Data.Repositories
{
    public class VeiculoRepository : RepositoryBase<Veiculo>, IVeiculoRepository
    {
        public IEnumerable<Veiculo> ConsultarPorMorador(int id)
        {
            return Db.Veiculo.Where(t => t.IdMorador == id);
        }

        public IEnumerable<Veiculo> ConsultarPorPredio(int id)
        {
            return Db.Veiculo.Where(t => t.IdPredio == id);
        }
    }
}
