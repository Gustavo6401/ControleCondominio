using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicoPortaria.Domain.Enttities
{
    class Veiculo
    {
        public int Id { get; set; }
        public int IdMorador { get; set; }
        public int IdPredio { get; set; }
        public int IdCondominio { get; set; }

        public Morador Morador { get; set; }
        public Predio Predio { get; set; }
        public Condominio Condominio { get; set; }
    }
}
