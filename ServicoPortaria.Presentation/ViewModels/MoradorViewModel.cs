using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ServicoPortaria.Presentation.ViewModels
{
    public class MoradorViewModel
    {
        [Key]
        [DisplayName("Código do Morador")]
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
        [MinLength(1, ErrorMessage = "DocCivil Inválido!")]
        [MaxLength(20, ErrorMessage = "DocCivil Inválido!")]
        [DisplayName("Documento Civil")]
        public string DocCivil { get; set; }
        [MinLength(1, ErrorMessage = "Sexo Inválido!")]
        [MaxLength(20, ErrorMessage = "Sexo Inválido!")]
        public string Sexo { get; set; }
        [MinLength(9, ErrorMessage = "CEP Inválido!")]
        [MaxLength(9, ErrorMessage = "CEP Inválido!")]
        public string CEP { get; set; }
        [MinLength(1, ErrorMessage = "Código Postal Inválido!")]
        [MaxLength(20, ErrorMessage = "Código Postal Inválido!")]
        [DisplayName("Código Postal")]
        public string CodigoPostal { get; set; }
        [MinLength(3, ErrorMessage = "Nome Inválido!")]
        [MaxLength(60, ErrorMessage = "Nome Inválido!")]
        public string Rua { get; set; }
        public int Numero { get; set; }
        [MinLength(1, ErrorMessage = "Nome Inválido!")]
        [MaxLength(30, ErrorMessage = "Nome Inválido!")]
        public string Cidade { get; set; }
        [MinLength(2, ErrorMessage = "Nome Inválido!")]
        [MaxLength(2, ErrorMessage = "Nome Inválido!")]
        public string Estado { get; set; }
        [MinLength(1, ErrorMessage = "Nome Inválido!")]
        [MaxLength(30, ErrorMessage = "Nome Inválido!")]
        public string Provincia { get; set; }
        [MinLength(1, ErrorMessage = "Nome Inválido!")]
        [MaxLength(20, ErrorMessage = "Nome Inválido!")]
        public string Pais { get; set; }
        [MinLength(1, ErrorMessage = "Número Inválido!")]
        [MaxLength(20, ErrorMessage = "Número Inválido!")]
        public string Celular { get; set; }
        [MinLength(1, ErrorMessage = "Número Inválido!")]
        [MaxLength(20, ErrorMessage = "Número Inválido!")]
        [DisplayName("Telefone Fixo")]
        public string Fixo { get; set; }
        [MinLength(1, ErrorMessage = "E-Mail Inválido!")]
        [MaxLength(255, ErrorMessage = "E-Mail Inválido!")]
        [EmailAddress(ErrorMessage = "E-Mail Inválido!")]
        [DisplayName("E-Mail")]
        public string EMail { get; set; }
        [DisplayName("Código do Condomínio")]
        public int IdCondominio { get; set; }

        public CondominioViewModel Condominio { get; set; }
    }
}
