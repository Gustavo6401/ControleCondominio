using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ServicoPortaria.Presentation.ViewModels
{
    public class Veiculo
    {
        [Key]
        [DisplayName("Código do Veículo")]
        public int Id { get; set; }
        [DisplayName("Código do Morador")]
        public int IdMorador { get; set; }
        [DisplayName("Código do Prédio")]
        public int IdPredio { get; set; }
        [DisplayName("Código do Condomínio")]
        public int IdCondominio { get; set; }

        public Morador Morador { get; set; }
        public PredioViewModel Predio { get; set; }
        public CondominioViewModel Condominio { get; set; }
    }
}
