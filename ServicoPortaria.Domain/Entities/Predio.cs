using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ServicoPortaria.Domain.Entities
{
    public class Predio
    {
        [Key]
        [DisplayName("Código do Prédio")]
        public int Id { get; set; }
        [MinLength(1, ErrorMessage = "Nome Inválido!")]
        [MaxLength(45, ErrorMessage = "Nome Inválido!")]
        public string Nome { get; set; }
        public int Numero { get; set; }
        [DisplayName("Código do Condomínio")]
        public int IdCondominio { get; set; }

        public Condominio Condominio { get; set; }
    }
}
