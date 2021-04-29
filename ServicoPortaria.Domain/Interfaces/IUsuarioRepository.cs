using System.Collections.Generic;
using ServicoPortaria.Domain.Entities;

namespace ServicoPortaria.Domain.Interfaces
{
    public interface IUsuarioRepository : IRepositoryBase<Usuario>
    {
        IEnumerable<Usuario> ConsultarUsuario(string usuario);
        IEnumerable<Usuario> ConsultarSenha(string senha);
        IEnumerable<Usuario> ConsultarNivelDeAcesso(string nivelAcesso);
    }
}
