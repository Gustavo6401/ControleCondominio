using System.Collections.Generic;
using ServicoPortaria.Domain.Enttities;

namespace ServicoPortaria.Domain.Interfaces
{
    public interface IRecuperacaoSenhaRepository : IRepositoryBase<RecuperacaoSenha>
    {
        IEnumerable<RecuperacaoSenha> ConsultarPorUsuario(string usuario);
        IEnumerable<RecuperacaoSenha> ConsultarPorSenha(string senha);
        IEnumerable<RecuperacaoSenha> ConsultarPorNivelAcesso(string nivelAcesso);
    }
}
