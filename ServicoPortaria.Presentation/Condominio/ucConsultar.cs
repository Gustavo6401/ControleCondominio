using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServicoPortaria.Infra.Data.Repositories;

namespace ServicoPortaria.Presentation.Condominio
{
    public partial class ucConsultar : UserControl
    {
        public ucConsultar()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            CondominioRepository repository = new CondominioRepository();
            dgvData.DataSource = repository.BuscarPorNome(nome); 
        }

        private void mskCEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            string cep = mskCEP.Text;

            CondominioRepository repository = new CondominioRepository();
            dgvData.DataSource = repository.BuscarPorCEP(cep);
        }

        private void txtCodPostal_TextChanged(object sender, EventArgs e)
        {
            string codPostal = txtCodPostal.Text;

            CondominioRepository repository = new CondominioRepository();
            dgvData.DataSource = repository.BuscarPorCodPostal(codPostal);
        }

        private void nudNumero_ValueChanged(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(nudNumero.Value);

            CondominioRepository repository = new CondominioRepository();
            dgvData.DataSource = repository.BuscarPorNumero(numero);
        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {
            string cidade = txtCidade.Text;

            CondominioRepository repository = new CondominioRepository();
            dgvData.DataSource = repository.BuscarPorCidade(cidade);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string cep = mskCEP.Text;
            string codPostal = txtCodPostal.Text;
            int numero = Convert.ToInt32(nudNumero.Value);
            string cidade = txtCidade.Text;

            CondominioRepository repository = new CondominioRepository();
            dgvData.DataSource = repository.BuscarComTodosOsFiltros(nome, cep, codPostal, numero, cidade);
        }
    }
}
