using System.ComponentModel.DataAnnotations;

namespace ServicoPortaria.Presentation.ViewModels
{
    public class Apartamento
    {
        [Key]
        public int Id { get; set; }
        public int Numero { get; set; }
        public int IdMorador { get; set; }
        public int IdPredio { get; set; }
        public int IdCondominio { get; set; }

        public Morador Morador { get; set; }
        public Predio Predio { get; set; }
        public Condominio Condominio { get; set; }
    }
}
