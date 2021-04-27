using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicoPortaria.Domain.Enttities
{
    class RecuperacaoSenha
    {
        public int Id { get; set; }
        public string EMail { get; set; }
        public int IdUsuario { get; set; }

        public int Usuario { get; set; }
    }
}
