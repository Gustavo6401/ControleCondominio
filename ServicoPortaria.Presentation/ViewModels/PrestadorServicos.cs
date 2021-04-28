using System.ComponentModel.DataAnnotations;

namespace ServicoPortaria.Presentation.ViewModels
{
    public class PrestadorServicos
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Por Favor, Preencha Este Campo.")]
        [MinLength(1, ErrorMessage = "Nome Inválido!")]
        [MaxLength(45, ErrorMessage = "Nome Inválido!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Por Favor, Preencha Este Campo.")]
        [MinLength(1, ErrorMessage = "Nome Inválido!")]
        [MaxLength(18, ErrorMessage = "Nome Inválido!")]
        public string CNPJ { get; set; }
        [Required(ErrorMessage = "Por Favor, Preencha Este Campo.")]
        [MinLength(1, ErrorMessage = "Nome Inválido!")]
        [MaxLength(14, ErrorMessage = "Nome Inválido!")]
        public string CPF { get; set; }
        public int IdPredio { get; set; }
        public int IdCondominio { get; set; }

        public Predio Predio { get; set; }
        public Condominio Condominio { get; set; }
    }
}
