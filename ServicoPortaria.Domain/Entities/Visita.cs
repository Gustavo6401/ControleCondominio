using ServicoPortaria.Domain.Enttities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicoPortaria.Domain.Entities
{
    public class Visita
    {
        public int Id { get; set; }
        public int IdVisitante { get; set; }
        public int IdMorador { get; set; }
        public TimeSpan Chegada { get; set; }
        public TimeSpan Saída { get; set; }
        public int IdCondominio { get; set; }
        public int IdPredio { get; set; }
        public int IdApartamento { get; set; }

        public Condominio Condominio { get; set; }
        public Predio Predio { get; set; }
        public Apartamento Apartamento { get; set; }
    }
}
