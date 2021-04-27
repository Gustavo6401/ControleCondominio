using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicoPortaria.Domain.Enttities
{
    class Condominio
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CEP { get; set; }
        public string CodPostal { get; set; }
        public int Numero { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Provincia { get; set; }
        public string Pais { get; set; }
    }
}
