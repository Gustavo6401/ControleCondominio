using System.Collections.Generic;
using ServicoPortaria.Domain.Entities;

namespace ServicoPortaria.Domain.Interfaces
{
    public interface IVeiculoRepository : IRepositoryBase<Veiculo>
    {
        IEnumerable<Veiculo> ConsultarPorMorador(int id);
        IEnumerable<Veiculo> ConsultarPorPredio(int id);
    }
}
