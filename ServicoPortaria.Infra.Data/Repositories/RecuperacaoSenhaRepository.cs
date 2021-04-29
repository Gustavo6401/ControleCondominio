using System.Linq;
using ServicoPortaria.Domain.Entities;
using ServicoPortaria.Domain.Interfaces;
using System.Collections.Generic;

namespace ServicoPortaria.Infra.Data.Repositories
{
    public class RecuperacaoSenhaRepository : RepositoryBase<RecuperacaoSenha>, IRecuperacaoSenhaRepository
    {
        public IEnumerable<RecuperacaoSenha> ConsultarPorNivelAcesso(string nivelAcesso)
        {
            return Db.RecuperacaoSenha.Where(t => t.Usuario.NivelDeAcesso.Contains(nivelAcesso));
        }

        public IEnumerable<RecuperacaoSenha> ConsultarPorEMail(string email)
        {
            return Db.RecuperacaoSenha.Where(t => t.EMail.Contains(email));
        }

        public IEnumerable<RecuperacaoSenha> ConsultarPorCelular(string celular)
        {
            return Db.RecuperacaoSenha.Where(t => t.Celular.Contains(celular));
        }

        IEnumerable<RecuperacaoSenha> IRecuperacaoSenhaRepository.ConsultarPorUsuario(string usuario)
        {
            throw new System.NotImplementedException();
        }

        IEnumerable<RecuperacaoSenha> IRecuperacaoSenhaRepository.ConsultarPorSenha(string senha)
        {
            throw new System.NotImplementedException();
        }
    }
}
