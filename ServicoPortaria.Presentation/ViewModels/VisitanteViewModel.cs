using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ServicoPortaria.Presentation.ViewModels
{
    public class VisitanteViewModel
    {
        [Key]
        [DisplayName("Código do Visitante")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Por Favor, Preencha Este Campo.")]
        [MinLength(1, ErrorMessage = "Nome Inválido!")]
        [MaxLength(20, ErrorMessage = "Nome Inválido!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Por Favor, Preencha Este Campo.")]
        [MinLength(1, ErrorMessage = "Nome Inválido!")]
        [MaxLength(60, ErrorMessage = "Nome Inválido!")]
        public string Sobrenome { get; set; }
        [MinLength(14, ErrorMessage = "CPF Inválido!")]
        [MaxLength(14, ErrorMessage = "CPF Inválido!")]
        public string CPF { get; set; }
        [MinLength(12, ErrorMessage = "RG Inválido!")]
        [MaxLength(12, ErrorMessage = "RG Inválido!")]
        public string RG { get; set; }
        [MinLength(1, ErrorMessage = "Documento Civil Inválido!")]
        [MaxLength(20, ErrorMessage = "Documento Civil Inválido!")]
        [DisplayName("Documento Civil")]
        public string DocCivil { get; set; }
        [Required(ErrorMessage = "Por Favor, Preencha Este Campo.")]
        [MinLength(1, ErrorMessage = "Sexo Inválido!")]
        [MaxLength(20, ErrorMessage = "Sexo Inválido!")]
        public string Sexo { get; set; }
        [Required(ErrorMessage = "Por Favor, Preencha Este Campo.")]
        [MinLength(1, ErrorMessage = "Número Inválido!")]
        [MaxLength(20, ErrorMessage = "´Número Inválido!")]
        public string Celular { get; set; }
        [Required(ErrorMessage = "Por Favor, Preencha Este Campo.")]
        [MinLength(1, ErrorMessage = "Número Inválido!")]
        [MaxLength(15, ErrorMessage = "Número Inválido!")]
        [DisplayName("Telefone Fixo")]
        public string Fixo { get; set; }
        [Required(ErrorMessage = "Por Favor, Preencha Este Campo.")]
        [MinLength(1, ErrorMessage = "E-Mail Inválido!")]
        [MaxLength(255, ErrorMessage = "E-Mail Inválido!")]
        [EmailAddress(ErrorMessage = "E-Mail Inválido!")]
        [DisplayName("E-Mail")]
        public string EMail { get; set; }
    }
}
