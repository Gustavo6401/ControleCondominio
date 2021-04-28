using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicoPortaria.Domain.Enttities
{
    public class Visitante
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string DocCivil { get; set; }
        public string Sexo { get; set; }
        public string Celular { get; set; }
        public string Fixo { get; set; }
        public string EMail { get; set; }
    }
}
