using System.Linq;
using ServicoPortaria.Domain.Entities;
using ServicoPortaria.Domain.Interfaces;
using System.Collections.Generic;

namespace ServicoPortaria.Infra.Data.Repositories
{
    public class SindicoRepository : RepositoryBase<Sindico>, ISindicoRepository
    {
        public IEnumerable<Sindico> ConsultarCondominio(int id)
        {
            return Db.Sindico.Where(t => t.IdCondominio == id);
        }

        public IEnumerable<Sindico> ConsultarCPF(string cpf)
        {
            return Db.Sindico.Where(t => t.CPF.Contains(cpf));
        }

        public IEnumerable<Sindico> ConsultarDocCivil(string docCivil)
        {
            return Db.Sindico.Where(t => t.DocCivil.Contains(docCivil));
        }

        public IEnumerable<Sindico> ConsultarNome(string nome)
        {
            return Db.Sindico.Where(t => t.Nome.Contains(nome));
        }

        public IEnumerable<Sindico> ConsultarPredio(int id)
        {
            return Db.Sindico.Where(t => t.IdPredio == id);
        }

        public IEnumerable<Sindico> ConsultarRG(string rg)
        {
            return Db.Sindico.Where(t => t.RG.Contains(rg));
        }

        public IEnumerable<Sindico> ConsultarSobrenome(string sobrenome)
        {
            return Db.Sindico.Where(t => t.Sobrenome.Contains(sobrenome));
        }
    }
}
