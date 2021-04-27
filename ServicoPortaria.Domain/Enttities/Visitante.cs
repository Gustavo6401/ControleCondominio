using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicoPortaria.Domain.Enttities
{
    class Visitante
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
        public int IdCondominio { get; set; }
        public int IdPredio { get; set; }
        public int IdApartamento { get; set; }

        public Condominio Condominio { get; set; }
        public Predio Predio { get; set; }
        public Apartamento Apartamento { get; set; }
    }
}
