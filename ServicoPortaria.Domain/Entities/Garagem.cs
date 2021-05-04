using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ServicoPortaria.Domain.Entities
{
    public class Garagem
    {
        [Key]
        [DisplayName("Código da Garagem")]
        public int Id { get; set; }
        public int Numero { get; set; }
        [DisplayName("Código do Prédio")]
        public int IdPredio { get; set; }
        [DisplayName("Código do Condomínio")]
        public int IdCondominio { get; set; }

        public Predio Predio { get; set; }
        public Condominio Condominio { get; set; }
    }
}
