using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ServicoPortaria.Domain.Entities
{
    public class Visita
    {
        [Key]
        [DisplayName("Código da Visita")]
        public int Id { get; set; }
        [DisplayName("Código do Visitante")]
        public int IdVisitante { get; set; }
        [DisplayName("Código do Morador")]
        public int IdMorador { get; set; }
        public DateTime DataDaChegada { get; set; }
        [Timestamp]
        public TimeSpan Chegada { get; set; }
        [Timestamp]
        public TimeSpan Saida { get; set; }
        public DateTime DataSaida { get; set; }
        [DisplayName("Código do Condomínio")]
        public int IdCondominio { get; set; }
        [DisplayName("Código do Prédio")]
        public int IdPredio { get; set; }
        [DisplayName("Código do Apartamento")]
        public int IdApartamento { get; set; }

        public Condominio Condominio { get; set; }
        public Predio Predio { get; set; }
        public Apartamento Apartamento { get; set; }
    }
}
