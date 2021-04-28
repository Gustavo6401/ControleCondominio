using ServicoPortaria.Domain.Enttities;
using ServicoPortaria.Domain.Interfaces;
using System.Collections.Generic;

namespace ServicoPortaria.Infra.Data.Repositories
{
    public class MoradorRepository : RepositoryBase<Morador>, IMoradorRepository
    {
        public IEnumerable<Morador> BuscarPorCelular(string celular)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Morador> BuscarPorCEP(string cep)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Morador> BuscarPorCodPostal(string codPostal)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Morador> BuscarPorCPF(string cpf)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Morador> BuscarPorDocCivil(string docCivil)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Morador> BuscarPorEMail(string email)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Morador> BuscarPorFoneFixo(string fixo)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Morador> BuscarPorNome(string nome)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Morador> BuscarPorNumero(int numero)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Morador> BuscarPorRG(string rg)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Morador> BuscarPorRua(string rua)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Morador> BuscarPorSobrenome(string sobrenome)
        {
            throw new System.NotImplementedException();
        }
    }
}
