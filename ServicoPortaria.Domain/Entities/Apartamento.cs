using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ServicoPortaria.Domain.Entities
{
    public class Apartamento
    {
        [Key]
        [DisplayName("Código do Apartamento")]
        public int Id { get; set; }
        [DisplayName("Número do Apartamento")]
        public int Numero { get; set; }
        public string Bloco { get; set; }
        public string Ramal { get; set; }
        [DisplayName("Código do Morador")]
        public int IdMorador { get; set; }
        [DisplayName("Código do Prédio")]
        public int IdPredio { get; set; }
        [DisplayName("Código do Condomínio")]
        public int IdCondominio { get; set; }

        public Morador Morador { get; set; }
        public Predio Predio { get; set; }
        public Condominio Condominio { get; set; }
    }
}
