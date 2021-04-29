using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ServicoPortaria.Domain.Entities
{
    public class Usuario
    {
        [Key]
        [DisplayName("Código do Usuário")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Por Favor, Preencha Este Campo.")]
        [MinLength(1, ErrorMessage = "Nome Inválido!")]
        [MaxLength(100, ErrorMessage = "Nome Inválido!")]
        [DisplayName("Nome de Usuário")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Por Favor, Preencha Este Campo.")]
        [MinLength(1, ErrorMessage = "Senha Inválida!")]
        [MaxLength(100, ErrorMessage = "Senha Inválida!")]
        [PasswordPropertyText]
        public string Senha { get; set; }
        public string NivelDeAcesso { get; set; }
    }
}
