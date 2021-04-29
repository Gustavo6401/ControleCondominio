using System.Linq;
using ServicoPortaria.Domain.Entities;
using ServicoPortaria.Domain.Interfaces;
using System.Collections.Generic;

namespace ServicoPortaria.Infra.Data.Repositories
{
    public class MoradorRepository : RepositoryBase<Morador>, IMoradorRepository
    {
        public IEnumerable<Morador> BuscarPorCelular(string celular)
        {
            return Db.Morador.Where(t => t.Celular.Contains(celular));
        }

        public IEnumerable<Morador> BuscarPorCEP(string cep)
        {
            return Db.Morador.Where(t => t.CEP.Contains(cep));
        }

        public IEnumerable<Morador> BuscarPorCodPostal(string codPostal)
        {
            return Db.Morador.Where(t => t.CodigoPostal.Contains(codPostal));
        }

        public IEnumerable<Morador> BuscarPorCPF(string cpf)
        {
            return Db.Morador.Where(t => t.CPF.Contains(cpf));
        }

        public IEnumerable<Morador> BuscarPorDocCivil(string docCivil)
        {
            return Db.Morador.Where(t => t.DocCivil.Contains(docCivil));
        }

        public IEnumerable<Morador> BuscarPorEMail(string email)
        {
            return Db.Morador.Where(t => t.EMail.Contains(email));
        }

        public IEnumerable<Morador> BuscarPorFoneFixo(string fixo)
        {
            return Db.Morador.Where(t => t.Fixo.Contains(fixo));
        }

        public IEnumerable<Morador> BuscarPorNome(string nome)
        {
            return Db.Morador.Where(t => t.Nome.Contains(nome));
        }

        public IEnumerable<Morador> BuscarPorNumero(int numero)
        {
            return Db.Morador.Where(t => t.Numero == numero);
        }

        public IEnumerable<Morador> BuscarPorRG(string rg)
        {
            return Db.Morador.Where(t => t.RG.Contains(rg));
        }

        public IEnumerable<Morador> BuscarPorRua(string rua)
        {
            return Db.Morador.Where(t => t.Rua.Contains(rua));
        }

        public IEnumerable<Morador> BuscarPorSobrenome(string sobrenome)
        {
            return Db.Morador.Where(t => t.Sobrenome.Contains(sobrenome));
        }
    }
}
