using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicoPortaria.Domain.Enttities
{
    public class RecuperacaoSenha
    {
        public int Id { get; set; }
        public string EMail { get; set; }
        public string Celular { get; set; }
        public string Senha { get; set; }
        public int IdUsuario { get; set; }

        public Usuario Usuario { get; set; }
    }
}
