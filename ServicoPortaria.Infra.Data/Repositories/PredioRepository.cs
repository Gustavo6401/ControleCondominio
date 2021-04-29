using System.Linq;
using ServicoPortaria.Domain.Entities;
using ServicoPortaria.Domain.Interfaces;
using System.Collections.Generic;

namespace ServicoPortaria.Infra.Data.Repositories
{
    public class PredioRepository : RepositoryBase<Predio>, IPredioRepository
    {
        public IEnumerable<Predio> BuscarPorCondominio(int id)
        {
            return Db.Predio.Where(t => t.IdCondominio == id);
        }

        public IEnumerable<Predio> BuscarPorNome(string nome)
        {
            return Db.Predio.Where(t => t.Nome.Contains(nome));
        }

        public IEnumerable<Predio> BuscarPorNumero(int numero)
        {
            return Db.Predio.Where(t => t.Numero == numero);
        }
    }
}
