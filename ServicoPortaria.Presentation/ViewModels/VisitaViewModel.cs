using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ServicoPortaria.Presentation.ViewModels
{
    public class VisitaViewModel
    {
        [Key]
        [DisplayName("Código da Visita")]
        public int Id { get; set; }
        [DisplayName("Código do Visitante")]
        public int IdVisitante { get; set; }
        [DisplayName("Código do Morador")]
        public int IdMorador { get; set; }
        [Timestamp]
        public TimeSpan Chegada { get; set; }
        [Timestamp]
        public TimeSpan Saida { get; set; }
        [DisplayName("Código do Condomínio")]
        public int IdCondominio { get; set; }
        [DisplayName("Código do Prédio")]
        public int IdPredio { get; set; }
        [DisplayName("Código do Apartamento")]
        public int IdApartamento { get; set; }

        public CondominioViewModel Condominio { get; set; }
        public PredioViewModel Predio { get; set; }
        public ApartamentoViewModel Apartamento { get; set; }
    }
}
