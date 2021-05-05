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
            try
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

                MessageBox.Show("Prédio Inserido Com Sucesso",
                    "Inserir Condomínio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Ocorreu um Erro",
                    "Inserir Condomínio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
        int ConsultarCondominio(string nome)
        {
            Infra.Data.Contexto.PortariaContext Db = new Infra.Data.Contexto.PortariaContext();

            Domain.Entities.Condominio condominio = Db.Condominio.FirstOrDefault(t => t.Nome.Contains(nome));

            return condominio.Id;
        }

        private void tsmCondominio_Click(object sender, EventArgs e)
        {
            Condominio.Forms.frmInserir form = new Condominio.Forms.frmInserir();
            form.Show();
        }

        private void tsmPredio_Click(object sender, EventArgs e)
        {
            Predio.Forms.frmInserir form = new Predio.Forms.frmInserir();
            form.Show();
        }

        private void tsmMorador_Click(object sender, EventArgs e)
        {
            Morador.Forms.frmInserir form = new Morador.Forms.frmInserir();
            form.Show();
        }

        private void tsmApartamento_Click(object sender, EventArgs e)
        {
            Apartamento.Forms.frmInserir form = new Apartamento.Forms.frmInserir();
            form.Show();
        }

        private void tsmVisitante_Click(object sender, EventArgs e)
        {
            Visitante.Forms.frmInserir form = new Visitante.Forms.frmInserir();
            form.Show();
        }

        private void tsmGaragem_Click(object sender, EventArgs e)
        {
            Garagem.Forms.frmInserir form = new Garagem.Forms.frmInserir();
            form.Show();
        }

        private void tsmVeiculo_Click(object sender, EventArgs e)
        {
            Veiculo.Forms.frmInserir form = new Veiculo.Forms.frmInserir();
            form.Show();
        }

        private void tsmPrestadorDeServicos_Click(object sender, EventArgs e)
        {
            PrestadorDeServicos.Forms.frmInserir form = new PrestadorDeServicos.Forms.frmInserir();
            form.Show();
        }

        private void tsmSindico_Click(object sender, EventArgs e)
        {
            Sindico.Forms.frmInserir form = new Sindico.Forms.frmInserir();
            form.Show();
        }

        private void tsmHomePage_Click(object sender, EventArgs e)
        {
            Login.Forms.frmLogin form = new Login.Forms.frmLogin();
            form.Show();
        }

        private void tsmVisita_Click(object sender, EventArgs e)
        {
            Visita.Forms.frmInserir form = new Visita.Forms.frmInserir();
            form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lllConsultar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
    }
}
