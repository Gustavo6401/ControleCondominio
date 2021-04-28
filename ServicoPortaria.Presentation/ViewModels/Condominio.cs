using System.ComponentModel.DataAnnotations;

namespace ServicoPortaria.Presentation.ViewModels
{
    public class Condominio
    {
        // Aqui, farei os modelos e deixarei as regras de negócio
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Por Favor, Preencha Este Campo.")]
        [MinLength(1, ErrorMessage = "Nome Inválido!")]
        [MaxLength(20, ErrorMessage = "Nome Inválido!")]
        public string Nome { get; set; }
        // [Required(ErrorMessage = "Por Favor, Preencha Este Campo.")]
        [MinLength(9, ErrorMessage = "Nome Inválido!")]
        [MaxLength(9, ErrorMessage = "Nome Inválido!")]
        public string CEP { get; set; }
        [MinLength(1, ErrorMessage = "Nome Inválido!")]
        [MaxLength(20, ErrorMessage = "Nome Inválido!")]
        public string CodPostal { get; set; }
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
