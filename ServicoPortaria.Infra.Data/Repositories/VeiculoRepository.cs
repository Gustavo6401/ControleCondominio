using System.Linq;
using ServicoPortaria.Domain.Entities;
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

        IEnumerable<Veiculo> IVeiculoRepository.ConsultarPorMarca(string marca)
        {
            return Db.Veiculo.Where(t => t.Marca.Contains(marca));
        }

        IEnumerable<Veiculo> IVeiculoRepository.ConsultarPorModelo(string modelo)
        {
            return Db.Veiculo.Where(t => t.Modelo.Contains(modelo));
        }

        IEnumerable<Veiculo> IVeiculoRepository.ConsultarPorPlaca(string placa)
        {
            return Db.Veiculo.Where(t => t.Placa.Contains(placa));
        }
    }
}
