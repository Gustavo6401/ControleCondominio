using System.ComponentModel.DataAnnotations;

namespace ServicoPortaria.Presentation.ViewModels
{
    public class Predio
    {
        [Key]
        public int Id { get; set; }
        [MinLength(1, ErrorMessage = "Nome Inválido!")]
        [MaxLength(45, ErrorMessage = "Nome Inválido!")]
        public string Nome { get; set; }
        public int Numero { get; set; }
        public int IdCondominio { get; set; }

        public Condominio Condominio { get; set; }
    }
}
