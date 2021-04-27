using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicoPortaria.Domain.Enttities
{
    class Usuario
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Senha { get; set; }
        public string NívelDeAcesso { get; set; }
    }
}
