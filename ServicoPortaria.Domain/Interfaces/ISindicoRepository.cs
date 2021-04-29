using System.Collections.Generic;
using ServicoPortaria.Domain.Entities;

namespace ServicoPortaria.Domain.Interfaces
{
    public interface ISindicoRepository : IRepositoryBase<Sindico>
    {
        IEnumerable<Sindico> ConsultarNome(string nome);
        IEnumerable<Sindico> ConsultarSobrenome(string sobrenome);
        IEnumerable<Sindico> ConsultarCPF(string cpf);
        IEnumerable<Sindico> ConsultarRG(string rg);
        IEnumerable<Sindico> ConsultarDocCivil(string docCivil);
        IEnumerable<Sindico> ConsultarPredio(int id);
        IEnumerable<Sindico> ConsultarCondominio(int id);
    }
}
