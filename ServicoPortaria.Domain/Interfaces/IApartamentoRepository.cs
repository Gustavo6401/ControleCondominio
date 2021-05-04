using System.Collections.Generic;
using ServicoPortaria.Domain.Entities;

namespace ServicoPortaria.Domain.Interfaces
{
    public interface IApartamentoRepository : IRepositoryBase<Apartamento>
    {
        IEnumerable<Apartamento> BuscarPorCondominio(int id);
        IEnumerable<Apartamento> BuscarPorMorador(int id);
        IEnumerable<Apartamento> BuscarPorBloco(string bloco);
        IEnumerable<Apartamento> BuscarPorRamal(string ramal);
        IEnumerable<Apartamento> BuscarPorNumero(int numero);
    }
}
