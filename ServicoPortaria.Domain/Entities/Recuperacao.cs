using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ServicoPortaria.Domain.Entities
{
    public class RecuperacaoSenha
    {
        [Key]
        [DisplayName("Código da Recuperação")]
        public int Id { get; set; }
        [MinLength(1, ErrorMessage = "E-Mail Inválido!")]
        [MaxLength(255, ErrorMessage = "E-Mail Inválido!")]
        [EmailAddress(ErrorMessage = "E-Mail Inválido!")]
        [DisplayName("E-Mail")]
        public string EMail { get; set; }
        [Required(ErrorMessage = "Por Favor, Preencha Este Campo.")]
        [MinLength(1, ErrorMessage = "Número Inválido!")]
        [MaxLength(20, ErrorMessage = "Número Inválido!")]
        public string Celular { get; set; }
        [DisplayName("Código do Usuário")]
        public int IdUsuario { get; set; }

        public Usuario Usuario { get; set; }
    }
}
