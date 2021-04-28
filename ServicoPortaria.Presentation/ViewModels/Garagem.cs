using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ServicoPortaria.Presentation.ViewModels
{
    public class Garagem
    {
        [Key]
        [DisplayName("Código do Morador")]
        public int Id { get; set; }
        [DisplayName("Código do Prédio")]
        public int IdPredio { get; set; }
        [DisplayName("Código do Condomínio")]
        public int IdCondominio { get; set; }

        public Predio Predio { get; set; }
        public Condominio Condominio { get; set; }
    }
}
