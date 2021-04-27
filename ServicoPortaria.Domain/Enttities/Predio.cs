using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicoPortaria.Domain.Enttities
{
    public class Predio
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Numero { get; set; }
        public int IdCondominio { get; set; }

        public Condominio Condominio { get; set; }
    }
}
