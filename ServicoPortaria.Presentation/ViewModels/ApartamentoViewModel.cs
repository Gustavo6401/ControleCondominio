using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ServicoPortaria.Presentation.ViewModels
{
    public class ApartamentoViewModel
    {
        [Key]
        [DisplayName("Código do Apartamento")]
        public int Id { get; set; }
        [DisplayName("Número do Apartamento")]
        public int Numero { get; set; }
        [DisplayName("Código do Morador")]
        public int IdMorador { get; set; }
        [DisplayName("Código do Prédio")]
        public int IdPredio { get; set; }
        [DisplayName("Código do Condomínio")]
        public int IdCondominio { get; set; }

        public MoradorViewModel Morador { get; set; }
        public PredioViewModel Predio { get; set; }
        public CondominioViewModel Condominio { get; set; }
    }
}
