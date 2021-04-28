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
        [MinLength(14, ErrorMessage = "CPF Inválido!")]
        [MaxLength(14, ErrorMessage = "CPF Inválido!")]
        public string CPF { get; set; }
        [Required(ErrorMessage = "Por Favor, Preencha Este Campo.")]
        [MinLength(12, ErrorMessage = "RG Inválido!")]
        [MaxLength(12, ErrorMessage = "RG Inválido!")]
        public string RG { get; set; }
        [Required(ErrorMessage = "Por Favor, Preencha Este Campo.")]
        [MinLength(1, ErrorMessage = "Documento Civil Inválido!")]
        [MaxLength(20, ErrorMessage = "Documento Civil Inválido!")]
        public string DocCivil { get; set; }
        [Required(ErrorMessage = "Por Favor, Preencha Este Campo.")]
        [MinLength(1, ErrorMessage = "Número Inválido!")]
        [MaxLength(20, ErrorMessage = "Número Inválido!")]
        public string Telefone { get; set; }
        [Required(ErrorMessage = "Por Favor, Preencha Este Campo.")]
        [MinLength(1, ErrorMessage = "E-Mail Inválido!")]
        [MaxLength(255, ErrorMessage = "E-Mail Inválido!")]
        [EmailAddress(ErrorMessage = "E-Mail Inválido!")]
        public string EMail { get; set; }
        public int IdPredio { get; set; }
        public int IdCondominio { get; set; }

        public Predio Predio { get; set; }
        public Condominio Condominio { get; set; }
    }
}
