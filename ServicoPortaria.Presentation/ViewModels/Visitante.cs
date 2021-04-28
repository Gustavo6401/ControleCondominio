using System.ComponentModel.DataAnnotations;

namespace ServicoPortaria.Presentation.ViewModels
{
    public class Visitante
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
        [MinLength(14, ErrorMessage = "Nome Inválido!")]
        [MaxLength(14, ErrorMessage = "Nome Inválido!")]
        public string CPF { get; set; }
        [MinLength(12, ErrorMessage = "Nome Inválido!")]
        [MaxLength(12, ErrorMessage = "Nome Inválido!")]
        public string RG { get; set; }
        [MinLength(1, ErrorMessage = "Nome Inválido!")]
        [MaxLength(20, ErrorMessage = "Nome Inválido!")]
        public string DocCivil { get; set; }
        [Required(ErrorMessage = "Por Favor, Preencha Este Campo.")]
        [MinLength(1, ErrorMessage = "Nome Inválido!")]
        [MaxLength(20, ErrorMessage = "Nome Inválido!")]
        public string Sexo { get; set; }
        [Required(ErrorMessage = "Por Favor, Preencha Este Campo.")]
        [MinLength(1, ErrorMessage = "Nome Inválido!")]
        [MaxLength(20, ErrorMessage = "Nome Inválido!")]
        public string Celular { get; set; }
        [Required(ErrorMessage = "Por Favor, Preencha Este Campo.")]
        [MinLength(1, ErrorMessage = "Nome Inválido!")]
        [MaxLength(15, ErrorMessage = "Nome Inválido!")]
        public string Fixo { get; set; }
        [Required(ErrorMessage = "Por Favor, Preencha Este Campo.")]
        [MinLength(1, ErrorMessage = "Nome Inválido!")]
        [MaxLength(255, ErrorMessage = "Nome Inválido!")]
        public string EMail { get; set; }
    }
}
