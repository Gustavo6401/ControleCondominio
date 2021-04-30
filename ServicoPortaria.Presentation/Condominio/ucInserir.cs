using System;
using System.Windows.Forms;
using ServicoPortaria.Presentation.Condominio.Forms;
using ServicoPortaria.Infra.Data.Repositories;

namespace ServicoPortaria.Presentation.Condominio
{
    public partial class ucnInserir : UserControl
    {
        public ucnInserir()
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
                condominio.Estado = txtEstado.Text;
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

            ucListarTodos userControl = new ucListarTodos();
            form.Controls.Add(userControl);
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
    }
}
