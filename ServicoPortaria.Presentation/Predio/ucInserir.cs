using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServicoPortaria.Domain.Entities;
using ServicoPortaria.Infra.Data.Repositories;

namespace ServicoPortaria.Presentation.Predio
{
    public partial class ucInserir : UserControl
    {
        public ucInserir()
        {
            InitializeComponent();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {           
            // Escolho o Id com uma busca que faço pelo primeiro condomínio que tiver um nome igual ao do controle.
            Domain.Entities.Predio predio = new Domain.Entities.Predio();
            predio.Nome = txtNome.Text;
            predio.Numero = Convert.ToInt32(nudNumero.Value);
            predio.IdCondominio = ConsultarCondominio(txtCondominio.Text);

            lblIdCondominio.Text = Convert.ToString($"{predio.IdCondominio}");

            // Insiro as informações do prédio no banco de dados.
            PredioRepository repository = new PredioRepository();
            repository.Inserir(predio);
        }
        int ConsultarCondominio(string nome)
        {
            Infra.Data.Contexto.PortariaContext Db = new Infra.Data.Contexto.PortariaContext();

            Domain.Entities.Condominio condominio = Db.Condominio.FirstOrDefault(t => t.Nome.Contains(nome));

            return condominio.Id;
        }
    }
}
