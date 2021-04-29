using System.Collections.Generic;
using ServicoPortaria.Domain.Entities;

namespace ServicoPortaria.Domain.Interfaces
{
    public interface IApartamentoRepository : IRepositoryBase<Apartamento>
    {
        IEnumerable<Apartamento> BuscarPorCondominio(int id);
        IEnumerable<Apartamento> BuscarPorMorador(int id);
    }
}
