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
        [MinLength(1, ErrorMessage = "CNPJ Inválido!")]
        [MaxLength(18, ErrorMessage = "CNPJ Inválido!")]
        public string CNPJ { get; set; }
        [Required(ErrorMessage = "Por Favor, Preencha Este Campo.")]
        [MinLength(1, ErrorMessage = "CPF Inválido!")]
        [MaxLength(14, ErrorMessage = "CPF Inválido!")]
        public string CPF { get; set; }
        public int IdPredio { get; set; }
        public int IdCondominio { get; set; }

        public Predio Predio { get; set; }
        public Condominio Condominio { get; set; }
    }
}
