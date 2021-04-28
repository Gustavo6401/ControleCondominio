using System.ComponentModel.DataAnnotations;

namespace ServicoPortaria.Presentation.ViewModels
{
    public class RecuperacaoSenha
    {
        [Key]
        public int Id { get; set; }
        [MinLength(1, ErrorMessage = "E-Mail Inválido!")]
        [MaxLength(255, ErrorMessage = "E-Mail Inválido!")]
        [EmailAddress(ErrorMessage = "E-Mail Inválido!")]
        public string EMail { get; set; }
        [Required(ErrorMessage = "Por Favor, Preencha Este Campo.")]
        [MinLength(1, ErrorMessage = "Número Inválido!")]
        [MaxLength(20, ErrorMessage = "Número Inválido!")]
        public string Celular { get; set; }
        public int IdUsuario { get; set; }

        public Usuario Usuario { get; set; }
    }
}
