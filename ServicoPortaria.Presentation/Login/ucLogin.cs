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

            if (lblNivel.Visible == false && cmbNivelDeAcesso.Visible == false)
            {
                Usuario usuario;
                usuario = context.Usuario.FirstOrDefault(t => t.UserName.Equals(user)
                                                           && t.Senha.Equals(senha));

                if (usuario != null)
                {
                    mstMenu.Enabled = true;
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
            if(lblNivel.Visible == true && cmbNivelDeAcesso.Visible == true)
            {
                // Colhe os dados do usuário.
                Usuario usuario = new Usuario();
                usuario.UserName = txtUser.Text;
                usuario.Senha = txtPassword.Text;
                usuario.NivelDeAcesso = cmbNivelDeAcesso.Text;

                // Criptografa a Senha
                usuario.Senha = CriptografarSenha(usuario.Senha);

                UsuarioRepository repository = new UsuarioRepository();
                repository.Inserir(usuario);

                MessageBox.Show("Usuário Criado Com Sucesso!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ucLogin_Load(object sender, EventArgs e)
        {
            mstMenu.Enabled = false;
            lblNivel.Visible = false;
            cmbNivelDeAcesso.Visible = false;
        }

        private void lllRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Altera as Informações do Form
            btnLogin.Text = "Registre-se!";
            lblNivel.Visible = true;
            cmbNivelDeAcesso.Visible = true;
        }

        private void tsmCondominio_Click(object sender, EventArgs e)
        {
            Condominio.Forms.frmConsultarTodos form = new frmConsultarTodos();
            form.Show();

            Hide();
        }
    }
}
