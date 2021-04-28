using System.ComponentModel.DataAnnotations;

namespace ServicoPortaria.Presentation.ViewModels
{
    public class Sindico
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Por Favor, Preencha Este Campo.")]
        [MinLength(1, ErrorMessage = "Nome Inválido!")]
        [MaxLength(20, ErrorMessage = "Nome Inválido!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Por Favor, Preencha Este Campo.")]
        [MinLength(1, ErrorMessage = "Nome Inválido!")]
        [MaxLength(60, ErrorMessage = "Nome Inválido!")]
        public string Sobrenome { get; set; }
        [Required(ErrorMessage = "Por Favor, Preencha Este Campo.")]
        [MinLength(14, ErrorMessage = "Nome Inválido!")]
        [MaxLength(14, ErrorMessage = "Nome Inválido!")]
        public string CPF { get; set; }
        [Required(ErrorMessage = "Por Favor, Preencha Este Campo.")]
        [MinLength(12, ErrorMessage = "Nome Inválido!")]
        [MaxLength(12, ErrorMessage = "Nome Inválido!")]
        public string RG { get; set; }
        [Required(ErrorMessage = "Por Favor, Preencha Este Campo.")]
        [MinLength(1, ErrorMessage = "Nome Inválido!")]
        [MaxLength(20, ErrorMessage = "Nome Inválido!")]
        public string DocCivil { get; set; }
        [Required(ErrorMessage = "Por Favor, Preencha Este Campo.")]
        [MinLength(1, ErrorMessage = "Nome Inválido!")]
        [MaxLength(20, ErrorMessage = "Nome Inválido!")]
        public string Telefone { get; set; }
        [Required(ErrorMessage = "Por Favor, Preencha Este Campo.")]
        [MinLength(1, ErrorMessage = "Nome Inválido!")]
        [MaxLength(255, ErrorMessage = "Nome Inválido!")]
        public string EMail { get; set; }
        public int IdPredio { get; set; }
        public int IdCondominio { get; set; }

        public Predio Predio { get; set; }
        public Condominio Condominio { get; set; }
    }
}
