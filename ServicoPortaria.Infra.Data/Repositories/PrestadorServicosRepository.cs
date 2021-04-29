using System.Linq;
using ServicoPortaria.Domain.Entities;
using ServicoPortaria.Domain.Interfaces;
using System.Collections.Generic;

namespace ServicoPortaria.Infra.Data.Repositories
{
    public class PrestadorServicosRepository : RepositoryBase<PrestadorSevicos>, IPrestadorRepository
    {
        public IEnumerable<PrestadorSevicos> ConsultarPorCNPJ(string cnpj)
        {
            return Db.PrestadorServico.Where(t => t.CNPJ.Contains(cnpj));
        }

        public IEnumerable<PrestadorSevicos> ConsultarPorCondominio(int id)
        {
            return Db.PrestadorServico.Where(t => t.IdCondominio == id);
        }

        public IEnumerable<PrestadorSevicos> ConsultarPorCPF(string cpf)
        {
            return Db.PrestadorServico.Where(t => t.CPF == cpf);
        }

        public IEnumerable<PrestadorSevicos> ConsultarPorNome(string nome)
        {
            return Db.PrestadorServico.Where(t => t.Nome == nome);
        }

        public IEnumerable<PrestadorSevicos> ConsultarPorPredio(int id)
        {
            return Db.PrestadorServico.Where(t => t.IdPredio == id);
        }
    }
}
