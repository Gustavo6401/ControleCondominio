using System.ComponentModel.DataAnnotations;

namespace ServicoPortaria.Presentation.ViewModels
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Por Favor, Preencha Este Campo.")]
        [MinLength(1, ErrorMessage = "Nome Inválido!")]
        [MaxLength(100, ErrorMessage = "Nome Inválido!")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Por Favor, Preencha Este Campo.")]
        [MinLength(1, ErrorMessage = "Senha Inválida!")]
        [MaxLength(100, ErrorMessage = "Senha Inválida!")]
        public string Senha { get; set; }
        public string NivelDeAcesso { get; set; }
    }
}
