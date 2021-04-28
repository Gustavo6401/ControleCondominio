using System;
using System.ComponentModel.DataAnnotations;

namespace ServicoPortaria.Presentation.ViewModels
{
    public class Visita
    {
        [Key]
        public int Id { get; set; }
        public int IdVisitante { get; set; }
        public int IdMorador { get; set; }
        [Timestamp]
        public TimeSpan Chegada { get; set; }
        [Timestamp]
        public TimeSpan Saida { get; set; }
        public int IdCondominio { get; set; }
        public int IdPredio { get; set; }
        public int IdApartamento { get; set; }

        public Condominio Condominio { get; set; }
        public Predio Predio { get; set; }
        public Apartamento Apartamento { get; set; }
    }
}
