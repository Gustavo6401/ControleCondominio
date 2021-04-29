using System.Linq;
using ServicoPortaria.Domain.Entities;
using ServicoPortaria.Domain.Interfaces;
using System.Collections.Generic;

namespace ServicoPortaria.Infra.Data.Repositories
{
    public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
    {
        public IEnumerable<Usuario> ConsultarNivelDeAcesso(string nivelAcesso)
        {
            return Db.Usuario.Where(t => t.NivelDeAcesso.Contains(nivelAcesso));
        }

        public IEnumerable<Usuario> ConsultarSenha(string senha)
        {
            return Db.Usuario.Where(t => t.Senha.Contains(senha));
        }

        public IEnumerable<Usuario> ConsultarUsuario(string usuario)
        {
            return Db.Usuario.Where(t => t.UserName.Contains(usuario));
        }
    }
}
