using System.Linq;
using ServicoPortaria.Domain.Entities;
using ServicoPortaria.Domain.Interfaces;
using System.Collections.Generic;

namespace ServicoPortaria.Infra.Data.Repositories
{
    public class VisitanteRepository : RepositoryBase<Visitante>, IVisitanteRepository
    {
        public IEnumerable<Visitante> BuscarPorCPF(string cpf)
        {
            return Db.Visitante.Where(t => t.CPF.Contains(cpf));
        }

        public IEnumerable<Visitante> BuscarPorDocCivil(string docCivil)
        {
            return Db.Visitante.Where(t => t.DocCivil.Contains(docCivil));
        }

        public IEnumerable<Visitante> BuscarPorNome(string nome)
        {
            return Db.Visitante.Where(t => t.Nome.Contains(nome));
        }

        public IEnumerable<Visitante> BuscarPorRG(string rg)
        {
            return Db.Visitante.Where(t => t.RG.Contains(rg));
        }

        public IEnumerable<Visitante> BuscarPorSobrenome(string sobrenome)
        {
            return Db.Visitante.Where(t => t.Sobrenome.Contains(sobrenome));
        }
    }
}
