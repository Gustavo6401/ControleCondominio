using System.Linq;
using ServicoPortaria.Domain.Enttities;
using ServicoPortaria.Domain.Interfaces;
using System.Collections.Generic;

namespace ServicoPortaria.Infra.Data.Repositories
{
    public class RecuperacaoSenhaRepository : RepositoryBase<RecuperacaoSenha>, IRecuperacaoSenhaRepository
    {
        public IEnumerable<RecuperacaoSenha> ConsultarPorNivelAcesso(string nivelAcesso)
        {
            return Db.RecuperacaoSenha.Where(t => t.Usuario.NívelDeAcesso.Contains(nivelAcesso));
        }

        public IEnumerable<RecuperacaoSenha> ConsultarPorEMail(string email)
        {
            return Db.RecuperacaoSenha.Where(t => t.EMail.Contains(email));
        }

        public IEnumerable<RecuperacaoSenha> ConsultarPorCelular(string celular)
        {
            return Db.RecuperacaoSenha.Where(t => t.Celular.Contains(celular));
        }
    }
}
