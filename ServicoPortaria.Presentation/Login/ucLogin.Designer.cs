
namespace ServicoPortaria.Presentation.Login
{
    partial class ucLogin
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mstMenu = new System.Windows.Forms.MenuStrip();
            this.tsmCondominio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPredio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMorador = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmApartamento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVisitante = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGaragem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVeiculo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPrestadorServicos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSindico = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRecuperacaoSenha = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVisita = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.cmbNivelDeAcesso = new System.Windows.Forms.ComboBox();
            this.lllRegistro = new System.Windows.Forms.LinkLabel();
            this.mnsCondominio = new System.Windows.Forms.MenuStrip();
            this.tsmCadastroMorador = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConsultarMorador = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmModuloVisitante = new System.Windows.Forms.ToolStripMenuItem();
            this.lblClose = new System.Windows.Forms.Label();
            this.mstMenu.SuspendLayout();
            this.mnsCondominio.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstMenu
            // 
            this.mstMenu.BackColor = System.Drawing.Color.Black;
            this.mstMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.mstMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCondominio,
            this.tsmPredio,
            this.tsmMorador,
            this.tsmApartamento,
            this.tsmVisitante,
            this.tsmGaragem,
            this.tsmVeiculo,
            this.tsmPrestadorServicos,
            this.tsmSindico,
            this.tsmRecuperacaoSenha,
            this.tsmVisita});
            this.mstMenu.Location = new System.Drawing.Point(0, 0);
            this.mstMenu.Name = "mstMenu";
            this.mstMenu.Size = new System.Drawing.Size(144, 334);
            this.mstMenu.TabIndex = 0;
            this.mstMenu.Text = "Menu";
            this.mstMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mstMenu_ItemClicked);
            // 
            // tsmCondominio
            // 
            this.tsmCondominio.CheckOnClick = true;
            this.tsmCondominio.ForeColor = System.Drawing.Color.White;
            this.tsmCondominio.Name = "tsmCondominio";
            this.tsmCondominio.Size = new System.Drawing.Size(131, 19);
            this.tsmCondominio.Text = "Condomínio";
            this.tsmCondominio.Click += new System.EventHandler(this.tsmCondominio_Click);
            // 
            // tsmPredio
            // 
            this.tsmPredio.ForeColor = System.Drawing.Color.White;
            this.tsmPredio.Name = "tsmPredio";
            this.tsmPredio.Size = new System.Drawing.Size(131, 19);
            this.tsmPredio.Text = "Predio";
            // 
            // tsmMorador
            // 
            this.tsmMorador.ForeColor = System.Drawing.Color.White;
            this.tsmMorador.Name = "tsmMorador";
            this.tsmMorador.Size = new System.Drawing.Size(131, 19);
            this.tsmMorador.Text = "Morador";
            // 
            // tsmApartamento
            // 
            this.tsmApartamento.ForeColor = System.Drawing.Color.White;
            this.tsmApartamento.Name = "tsmApartamento";
            this.tsmApartamento.Size = new System.Drawing.Size(131, 19);
            this.tsmApartamento.Text = "Apartamento";
            // 
            // tsmVisitante
            // 
            this.tsmVisitante.ForeColor = System.Drawing.Color.White;
            this.tsmVisitante.Name = "tsmVisitante";
            this.tsmVisitante.Size = new System.Drawing.Size(131, 19);
            this.tsmVisitante.Text = "Visitante";
            // 
            // tsmGaragem
            // 
            this.tsmGaragem.ForeColor = System.Drawing.Color.White;
            this.tsmGaragem.Name = "tsmGaragem";
            this.tsmGaragem.Size = new System.Drawing.Size(131, 19);
            this.tsmGaragem.Text = "Garagem";
            // 
            // tsmVeiculo
            // 
            this.tsmVeiculo.ForeColor = System.Drawing.Color.White;
            this.tsmVeiculo.Name = "tsmVeiculo";
            this.tsmVeiculo.Size = new System.Drawing.Size(131, 19);
            this.tsmVeiculo.Text = "Veículo";
            // 
            // tsmPrestadorServicos
            // 
            this.tsmPrestadorServicos.ForeColor = System.Drawing.Color.White;
            this.tsmPrestadorServicos.Name = "tsmPrestadorServicos";
            this.tsmPrestadorServicos.Size = new System.Drawing.Size(131, 19);
            this.tsmPrestadorServicos.Text = "Prestador de Serviços";
            // 
            // tsmSindico
            // 
            this.tsmSindico.ForeColor = System.Drawing.Color.White;
            this.tsmSindico.Name = "tsmSindico";
            this.tsmSindico.Size = new System.Drawing.Size(131, 19);
            this.tsmSindico.Text = "Síndico";
            // 
            // tsmRecuperacaoSenha
            // 
            this.tsmRecuperacaoSenha.ForeColor = System.Drawing.Color.White;
            this.tsmRecuperacaoSenha.Name = "tsmRecuperacaoSenha";
            this.tsmRecuperacaoSenha.Size = new System.Drawing.Size(131, 19);
            this.tsmRecuperacaoSenha.Text = "Recuperação de Senha";
            // 
            // tsmVisita
            // 
            this.tsmVisita.ForeColor = System.Drawing.Color.White;
            this.tsmVisita.Name = "tsmVisita";
            this.tsmVisita.Size = new System.Drawing.Size(131, 19);
            this.tsmVisita.Text = "Visita";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(246, 155);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(47, 15);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Usuário";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(246, 188);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(39, 15);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Black;
            this.btnLogin.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(363, 241);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(120, 56);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(335, 185);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(148, 23);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(335, 152);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(148, 23);
            this.txtUser.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(495, -43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 25);
            this.label1.TabIndex = 39;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Location = new System.Drawing.Point(246, 117);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(90, 15);
            this.lblNivel.TabIndex = 40;
            this.lblNivel.Text = "Nível de Acesso";
            this.lblNivel.Visible = false;
            // 
            // cmbNivelDeAcesso
            // 
            this.cmbNivelDeAcesso.FormattingEnabled = true;
            this.cmbNivelDeAcesso.Items.AddRange(new object[] {
            "Master",
            "Síndico"});
            this.cmbNivelDeAcesso.Location = new System.Drawing.Point(335, 114);
            this.cmbNivelDeAcesso.Name = "cmbNivelDeAcesso";
            this.cmbNivelDeAcesso.Size = new System.Drawing.Size(148, 23);
            this.cmbNivelDeAcesso.TabIndex = 41;
            this.cmbNivelDeAcesso.Visible = false;
            // 
            // lllRegistro
            // 
            this.lllRegistro.AutoSize = true;
            this.lllRegistro.Location = new System.Drawing.Point(335, 223);
            this.lllRegistro.Name = "lllRegistro";
            this.lllRegistro.Size = new System.Drawing.Size(66, 15);
            this.lllRegistro.TabIndex = 42;
            this.lllRegistro.TabStop = true;
            this.lllRegistro.Text = "Registre-Se";
            this.lllRegistro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lllRegistro_LinkClicked);
            // 
            // mnsCondominio
            // 
            this.mnsCondominio.BackColor = System.Drawing.Color.Black;
            this.mnsCondominio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCadastroMorador,
            this.tsmConsultarMorador,
            this.tsmModuloVisitante});
            this.mnsCondominio.Location = new System.Drawing.Point(144, 0);
            this.mnsCondominio.Name = "mnsCondominio";
            this.mnsCondominio.Size = new System.Drawing.Size(423, 24);
            this.mnsCondominio.TabIndex = 52;
            this.mnsCondominio.Text = "Condomínio";
            // 
            // tsmCadastroMorador
            // 
            this.tsmCadastroMorador.ForeColor = System.Drawing.Color.White;
            this.tsmCadastroMorador.Name = "tsmCadastroMorador";
            this.tsmCadastroMorador.Size = new System.Drawing.Size(131, 20);
            this.tsmCadastroMorador.Text = "Cadastro de Morador";
            // 
            // tsmConsultarMorador
            // 
            this.tsmConsultarMorador.ForeColor = System.Drawing.Color.White;
            this.tsmConsultarMorador.Name = "tsmConsultarMorador";
            this.tsmConsultarMorador.Size = new System.Drawing.Size(133, 20);
            this.tsmConsultarMorador.Text = "Bloco do Condomíno";
            // 
            // tsmModuloVisitante
            // 
            this.tsmModuloVisitante.ForeColor = System.Drawing.Color.White;
            this.tsmModuloVisitante.Name = "tsmModuloVisitante";
            this.tsmModuloVisitante.Size = new System.Drawing.Size(125, 20);
            this.tsmModuloVisitante.Text = "Módulo de Visitante";
            // 
            // lblClose
            // 
            this.lblClose.BackColor = System.Drawing.Color.Red;
            this.lblClose.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(542, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(25, 25);
            this.lblClose.TabIndex = 61;
            this.lblClose.Text = "X";
            // 
            // ucLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.mnsCondominio);
            this.Controls.Add(this.lllRegistro);
            this.Controls.Add(this.cmbNivelDeAcesso);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.mstMenu);
            this.Name = "ucLogin";
            this.Size = new System.Drawing.Size(567, 334);
            this.Load += new System.EventHandler(this.ucLogin_Load);
            this.mstMenu.ResumeLayout(false);
            this.mstMenu.PerformLayout();
            this.mnsCondominio.ResumeLayout(false);
            this.mnsCondominio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmCondominio;
        private System.Windows.Forms.ToolStripMenuItem tsmPredio;
        private System.Windows.Forms.ToolStripMenuItem tsmMorador;
        private System.Windows.Forms.ToolStripMenuItem tsmApartamento;
        private System.Windows.Forms.ToolStripMenuItem tsmVisitante;
        private System.Windows.Forms.ToolStripMenuItem tsmGaragem;
        private System.Windows.Forms.ToolStripMenuItem tsmVeiculo;
        private System.Windows.Forms.ToolStripMenuItem tsmPrestadorServicos;
        private System.Windows.Forms.ToolStripMenuItem tsmSindico;
        private System.Windows.Forms.ToolStripMenuItem tsmRecuperacaoSenha;
        private System.Windows.Forms.ToolStripMenuItem tsmVisita;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.ComboBox cmbNivelDeAcesso;
        private System.Windows.Forms.LinkLabel lllRegistro;
        private System.Windows.Forms.MenuStrip mnsCondominio;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastroMorador;
        private System.Windows.Forms.ToolStripMenuItem tsmConsultarMorador;
        private System.Windows.Forms.ToolStripMenuItem tsmModuloVisitante;
        private System.Windows.Forms.Label lblClose;
    }
}
