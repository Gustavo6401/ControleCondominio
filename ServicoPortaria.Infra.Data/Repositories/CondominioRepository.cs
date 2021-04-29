using System.Linq;
using System.Text.RegularExpressions;
using ServicoPortaria.Domain.Entities;
using ServicoPortaria.Domain.Interfaces;
using System.Collections.Generic;

namespace ServicoPortaria.Infra.Data.Repositories
{
    public class CondominioRepository : RepositoryBase<Condominio>, ICondominioRepository
    {
        Regex er = new Regex(@".");
        public IEnumerable<Condominio> BuscarPorCEP(string cep)
        {
            er.Match(cep);

            return Db.Condominio.Where(t => t.CEP.Contains(cep));
        }

        public IEnumerable<Condominio> BuscarPorCodPostal(string codPostal)
        {
            er.Match(codPostal);

            return Db.Condominio.Where(t => t.CodPostal.Contains(codPostal));
        }

        public IEnumerable<Condominio> BuscarPorNome(string nome)
        {
            er.Match(nome);

            return Db.Condominio.Where(t => t.Nome.Contains(nome));
        }

        public IEnumerable<Condominio> BuscarPorNumero(int numero)
        {
            return Db.Condominio.Where(t => t.Numero == numero);
        }
    }
}
