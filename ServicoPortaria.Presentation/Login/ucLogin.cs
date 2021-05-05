using System;
using System.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using ServicoPortaria.Presentation.Condominio.Forms;
using ServicoPortaria.Presentation.Login.Forms;
using ServicoPortaria.Infra.Data.Contexto;
using ServicoPortaria.Infra.Data.Repositories;
using ServicoPortaria.Domain.Entities;

namespace ServicoPortaria.Presentation.Login
{
    public partial class ucLogin : UserControl
    {
        public ucLogin()
        {
            InitializeComponent();
        }
        private void mstMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        string CriptografarSenha(string texto)
        {
            MD5 md5 = MD5.Create();

            byte[] textoBytes = Encoding.UTF8.GetBytes(texto);
            byte[] criptografiaBytes = md5.ComputeHash(textoBytes);

            return Convert.ToBase64String(criptografiaBytes);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string senha = txtPassword.Text;
            string user = txtUser.Text;

            senha = CriptografarSenha(senha);

            PortariaContext context = new PortariaContext();           
            
            Usuario usuario;
            usuario = context.Usuario.FirstOrDefault(t => t.UserName.Equals(user)
                                                           && t.Senha.Equals(senha));

            if (usuario != null)
            {
                 lblUser.Visible = false;
                 lblSenha.Visible = false;
                 txtUser.Visible = false;
                 txtPassword.Visible = false;
                 btnLogin.Visible = false;
                 lllRegistro.Visible = false;

                 frmLogin form = new frmLogin();
                 form.Hide();
            }
            else
            {
                 MessageBox.Show("Nome de Usuário e/ou senha incorretos.");
            }
        }

        private void tsmCondomínio_Click(object sender, EventArgs e)
        {
            frmInserir form = new frmInserir();
            form.Show();
        }

        private void tsmPredio_Click(object sender, EventArgs e)
        {
            Predio.Forms.frmInserir form = new Predio.Forms.frmInserir();
            form.Show();
        }

        private void frnMorador_Click(object sender, EventArgs e)
        {
            Morador.Forms.frmInserir form = new Morador.Forms.frmInserir();
            form.Show();
        }

        private void tsmApartamento_Click(object sender, EventArgs e)
        {
            Apartamento.Forms.frmInserir form = new Apartamento.Forms.frmInserir();
            form.Show();
        }

        private void tsmVistante_Click(object sender, EventArgs e)
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

        private void frmVisita_Click(object sender, EventArgs e)
        {
            Visita.Forms.frmInserir form = new Visita.Forms.frmInserir();
            form.Show();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}