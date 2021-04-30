using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ServicoPortaria.Domain.Entities
{
    public class Condominio
    {
        [Key]
        [DisplayName("Código do Condomínio")]
        public int Id { get; set; }
        [DisplayName("Nome")]
        [Required(ErrorMessage = "Por Favor, Preencha Este Campo.")]
        [MinLength(1, ErrorMessage = "Nome Inválido!")]
        [MaxLength(50, ErrorMessage = "Nome Inválido!")]
        public string Nome { get; set; }
        [MinLength(9, ErrorMessage = "CEP Inválido!")]
        [MaxLength(9, ErrorMessage = "CEP Inválido!")]
        public string CEP { get; set; }
        [MaxLength(20, ErrorMessage = "Código Postal Inválido!")]
        [DisplayName("Código Postal")]
        public string CodPostal { get; set; }
        [MinLength(1, ErrorMessage = "Nome Inválido!")]
        [MaxLength(90, ErrorMessage = "Nome Inválido!")]
        public string Rua { get; set; }
        [DisplayName("Número do Condomínio")]
        public int Numero { get; set; }
        [Required(ErrorMessage = "Por Favor, Preencha Este Campo.")]
        [MinLength(1, ErrorMessage = "Nome Inválido!")]
        [MaxLength(30, ErrorMessage = "Nome Inválido!")]
        public string Cidade { get; set; }
        [MinLength(2, ErrorMessage = "Nome Inválido!")]
        [MaxLength(2, ErrorMessage = "Nome Inválido!")]
        public string Estado { get; set; }
        public string Provincia { get; set; }
        public string Pais { get; set; }
    }
}
