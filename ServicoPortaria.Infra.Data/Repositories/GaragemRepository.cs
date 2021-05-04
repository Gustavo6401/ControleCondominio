using ServicoPortaria.Domain.Entities;
using ServicoPortaria.Domain.Interfaces;
using System.Linq;
using System.Collections.Generic;

namespace ServicoPortaria.Infra.Data.Repositories
{
    public class GaragemRepository : RepositoryBase<Garagem>, IGaragemRepository
    {
        IEnumerable<Garagem> IGaragemRepository.BuscarPorCondominio(int id)
        {
            return Db.Garagem.Where(t => t.IdCondominio == id);
        }

        IEnumerable<Garagem> IGaragemRepository.BuscarPorNumero(int numero)
        {
            return Db.Garagem.Where(t => t.Numero == numero);
        }

        IEnumerable<Garagem> IGaragemRepository.BuscarPorPredio(int id)
        {
            return Db.Garagem.Where(t => t.IdPredio == id);
        }
    }
}
