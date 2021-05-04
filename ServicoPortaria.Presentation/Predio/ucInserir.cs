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
            ServicoPortaria.Domain.Entities.Predio condominio = new Domain.Entities.Predio();
            condominio.Nome = txtNome.Text;
            condominio.Numero = Convert.ToInt32(nudNumero.Value);
            condominio.IdCondominio = Convert.ToInt32(lblIdCondominio.Text);
        }
    }
}
