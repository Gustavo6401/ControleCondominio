using System.Collections.Generic;
using ServicoPortaria.Domain.Entities;

namespace ServicoPortaria.Domain.Interfaces
{
    public interface IVisitanteRepository : IRepositoryBase<Visitante>
    {
        IEnumerable<Visitante> BuscarPorNome(string nome);
        IEnumerable<Visitante> BuscarPorSobrenome(string sobrenome);
        IEnumerable<Visitante> BuscarPorCPF(string cpf);
        IEnumerable<Visitante> BuscarPorRG(string rg);
        IEnumerable<Visitante> BuscarPorDocCivil(string docCivil);
    }
}
