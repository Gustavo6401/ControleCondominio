using System;
using System.Windows.Forms;
using ServicoPortaria.Presentation.Condominio.Forms;
using ServicoPortaria.Infra.Data.Repositories;

namespace ServicoPortaria.Presentation.Condominio
{
    public partial class ucInserir : UserControl
    {
        public ucInserir()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                Domain.Entities.Condominio condominio = new Domain.Entities.Condominio();
                condominio.Nome = txtNome.Text;
                condominio.CEP = mtxCEP.Text;
                condominio.CodPostal = txtCodPostal.Text;
                condominio.Rua = txtRua.Text;
                condominio.Numero = Convert.ToInt32(nudNumero.Value);
                condominio.Cidade = txtCidade.Text;
                condominio.Estado = cmbEstado.Text;
                condominio.Provincia = txtProvincia.Text;
                condominio.Pais = txtPais.Text;

                CondominioRepository repository = new CondominioRepository();
                repository.Inserir(condominio);

                MessageBox.Show("Nome de Condomínio Inserido Com Sucesso!",
                    "Cadastro Condomínio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            } catch
            {
                MessageBox.Show($"Ocorreu um erro!",
                    "Cadastro Condomínio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void tsmConsultar_Click(object sender, EventArgs e)
        {
            frmInserir form = new frmInserir();
            Dispose();

            frmConsultar consultar = new frmConsultar();
            consultar.Show();
        }
        private void tsmConsultarComId_Click(object sender, EventArgs e)
        {
            frmConsultarPorId form = new frmConsultarPorId();
            form.Show();

            frmInserir inserir = new frmInserir();
            inserir.Close();
        }

        private void tsmConsultarTodos_Click(object sender, EventArgs e)
        {
            frmConsultarTodos form = new frmConsultarTodos();
            form.Show();

            frmInserir tela = new frmInserir();
            tela.Close();
        }

        private void tsmUpdate_Click(object sender, EventArgs e)
        {
            frmModificar form = new frmModificar();
            form.Show();

            frmInserir tela = new frmInserir();
            tela.Close();
        }

        private void tsmRemove_Click(object sender, EventArgs e)
        {
            frmDeletar form = new frmDeletar();
            form.Show();

            frmInserir tela = new frmInserir();
            tela.Close();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnsCondominio_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tsmConsultar_Click(object sender, PaintEventArgs e)
        {
            frmConsultar form = new frmConsultar();
            Dispose();

            form.Show();
        }

        private void tsmInserir_Click(object sender, EventArgs e)
        {

        }

        private void tsmPredio_Click(object sender, EventArgs e)
        {
            Predio.Forms.frmInserir inserir = new Predio.Forms.frmInserir();
            inserir.Show();
        }

        private void tsmCondominio_Click(object sender, EventArgs e)
        {
            frmInserir form = new frmInserir();
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

        private void lllConsultar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmConsultar form = new frmConsultar();
            form.Show();
        }

        private void lllConsultarTodos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmConsultarTodos form = new frmConsultarTodos();
            form.Show();
        }

        private void lllModificarDados_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmModificar form = new frmModificar();
            form.Show();
        }

        private void lllDeletarDados_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDeletar form = new frmDeletar();
            form.Show();
        }
    }
}
