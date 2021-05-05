
namespace ServicoPortaria.Presentation.Predio
{
    partial class ucInserir
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblCondominio = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCondominio = new System.Windows.Forms.TextBox();
            this.nudNumero = new System.Windows.Forms.NumericUpDown();
            this.lblIdCondominio = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.mnsCondominio = new System.Windows.Forms.MenuStrip();
            this.tsmCondomínio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPredio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMorador = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmApartamento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVisitante = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGaragem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVeiculo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPrestadorDeServicos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSindico = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHomePage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVisita = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.groupFunções = new System.Windows.Forms.GroupBox();
            this.lllDeletarDados = new System.Windows.Forms.LinkLabel();
            this.lllModificarDados = new System.Windows.Forms.LinkLabel();
            this.lllConsultarTodos = new System.Windows.Forms.LinkLabel();
            this.lllConsultar = new System.Windows.Forms.LinkLabel();
            this.groupPredio = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).BeginInit();
            this.mnsCondominio.SuspendLayout();
            this.groupFunções.SuspendLayout();
            this.groupPredio.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(43, 49);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 15);
            this.lblNome.TabIndex = 48;
            this.lblNome.Text = "Nome";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(43, 100);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(51, 15);
            this.lblNumero.TabIndex = 49;
            this.lblNumero.Text = "Número";
            // 
            // lblCondominio
            // 
            this.lblCondominio.AutoSize = true;
            this.lblCondominio.Location = new System.Drawing.Point(43, 157);
            this.lblCondominio.Name = "lblCondominio";
            this.lblCondominio.Size = new System.Drawing.Size(74, 15);
            this.lblCondominio.TabIndex = 50;
            this.lblCondominio.Text = "Condomínio";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(192, 46);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(207, 23);
            this.txtNome.TabIndex = 52;
            // 
            // txtCondominio
            // 
            this.txtCondominio.Location = new System.Drawing.Point(192, 154);
            this.txtCondominio.Name = "txtCondominio";
            this.txtCondominio.Size = new System.Drawing.Size(207, 23);
            this.txtCondominio.TabIndex = 53;
            // 
            // nudNumero
            // 
            this.nudNumero.Location = new System.Drawing.Point(192, 98);
            this.nudNumero.Name = "nudNumero";
            this.nudNumero.Size = new System.Drawing.Size(207, 23);
            this.nudNumero.TabIndex = 54;
            // 
            // lblIdCondominio
            // 
            this.lblIdCondominio.AutoSize = true;
            this.lblIdCondominio.Location = new System.Drawing.Point(43, 220);
            this.lblIdCondominio.Name = "lblIdCondominio";
            this.lblIdCondominio.Size = new System.Drawing.Size(119, 15);
            this.lblIdCondominio.TabIndex = 55;
            this.lblIdCondominio.Text = "Cód. do Condomínio";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Black;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(89, 258);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(259, 58);
            this.btnCadastrar.TabIndex = 56;
            this.btnCadastrar.Text = "Cadastrar Prédio";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // mnsCondominio
            // 
            this.mnsCondominio.BackColor = System.Drawing.Color.Black;
            this.mnsCondominio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCondomínio,
            this.tsmPredio,
            this.tsmMorador,
            this.tsmApartamento,
            this.tsmVisitante,
            this.tsmGaragem,
            this.tsmVeiculo,
            this.tsmPrestadorDeServicos,
            this.tsmSindico,
            this.tsmHomePage,
            this.tsmVisita});
            this.mnsCondominio.Location = new System.Drawing.Point(0, 0);
            this.mnsCondominio.Name = "mnsCondominio";
            this.mnsCondominio.Size = new System.Drawing.Size(1730, 24);
            this.mnsCondominio.TabIndex = 86;
            this.mnsCondominio.Text = "Condomínio";
            // 
            // tsmCondomínio
            // 
            this.tsmCondomínio.ForeColor = System.Drawing.Color.White;
            this.tsmCondomínio.Name = "tsmCondomínio";
            this.tsmCondomínio.Size = new System.Drawing.Size(86, 20);
            this.tsmCondomínio.Text = "Condomínio";
            this.tsmCondomínio.Click += new System.EventHandler(this.tsmCondominio_Click);
            // 
            // tsmPredio
            // 
            this.tsmPredio.ForeColor = System.Drawing.Color.White;
            this.tsmPredio.Name = "tsmPredio";
            this.tsmPredio.Size = new System.Drawing.Size(53, 20);
            this.tsmPredio.Text = "Prédio";
            this.tsmPredio.Click += new System.EventHandler(this.tsmPredio_Click);
            // 
            // tsmMorador
            // 
            this.tsmMorador.ForeColor = System.Drawing.Color.White;
            this.tsmMorador.Name = "tsmMorador";
            this.tsmMorador.Size = new System.Drawing.Size(65, 20);
            this.tsmMorador.Text = "Morador";
            this.tsmMorador.Click += new System.EventHandler(this.tsmMorador_Click);
            // 
            // tsmApartamento
            // 
            this.tsmApartamento.ForeColor = System.Drawing.Color.White;
            this.tsmApartamento.Name = "tsmApartamento";
            this.tsmApartamento.Size = new System.Drawing.Size(89, 20);
            this.tsmApartamento.Text = "Apartamento";
            this.tsmApartamento.Click += new System.EventHandler(this.tsmApartamento_Click);
            // 
            // tsmVisitante
            // 
            this.tsmVisitante.ForeColor = System.Drawing.Color.White;
            this.tsmVisitante.Name = "tsmVisitante";
            this.tsmVisitante.Size = new System.Drawing.Size(64, 20);
            this.tsmVisitante.Text = "Visitante";
            this.tsmVisitante.Click += new System.EventHandler(this.tsmVisitante_Click);
            // 
            // tsmGaragem
            // 
            this.tsmGaragem.ForeColor = System.Drawing.Color.White;
            this.tsmGaragem.Name = "tsmGaragem";
            this.tsmGaragem.Size = new System.Drawing.Size(67, 20);
            this.tsmGaragem.Text = "Garagem";
            this.tsmGaragem.Click += new System.EventHandler(this.tsmGaragem_Click);
            // 
            // tsmVeiculo
            // 
            this.tsmVeiculo.ForeColor = System.Drawing.Color.White;
            this.tsmVeiculo.Name = "tsmVeiculo";
            this.tsmVeiculo.Size = new System.Drawing.Size(57, 20);
            this.tsmVeiculo.Text = "Veículo";
            this.tsmVeiculo.Click += new System.EventHandler(this.tsmVeiculo_Click);
            // 
            // tsmPrestadorDeServicos
            // 
            this.tsmPrestadorDeServicos.ForeColor = System.Drawing.Color.White;
            this.tsmPrestadorDeServicos.Name = "tsmPrestadorDeServicos";
            this.tsmPrestadorDeServicos.Size = new System.Drawing.Size(131, 20);
            this.tsmPrestadorDeServicos.Text = "Prestador de Serviços";
            this.tsmPrestadorDeServicos.Click += new System.EventHandler(this.tsmPrestadorDeServicos_Click);
            // 
            // tsmSindico
            // 
            this.tsmSindico.ForeColor = System.Drawing.Color.White;
            this.tsmSindico.Name = "tsmSindico";
            this.tsmSindico.Size = new System.Drawing.Size(58, 20);
            this.tsmSindico.Text = "Síndico";
            this.tsmSindico.Click += new System.EventHandler(this.tsmSindico_Click);
            // 
            // tsmHomePage
            // 
            this.tsmHomePage.ForeColor = System.Drawing.Color.White;
            this.tsmHomePage.Name = "tsmHomePage";
            this.tsmHomePage.Size = new System.Drawing.Size(81, 20);
            this.tsmHomePage.Text = "Home Page";
            this.tsmHomePage.Click += new System.EventHandler(this.tsmHomePage_Click);
            // 
            // tsmVisita
            // 
            this.tsmVisita.ForeColor = System.Drawing.Color.White;
            this.tsmVisita.Name = "tsmVisita";
            this.tsmVisita.Size = new System.Drawing.Size(47, 20);
            this.tsmVisita.Text = "Visita";
            this.tsmVisita.Click += new System.EventHandler(this.tsmVisita_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1705, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 25);
            this.label1.TabIndex = 88;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupFunções
            // 
            this.groupFunções.Controls.Add(this.lllDeletarDados);
            this.groupFunções.Controls.Add(this.lllModificarDados);
            this.groupFunções.Controls.Add(this.lllConsultarTodos);
            this.groupFunções.Controls.Add(this.lllConsultar);
            this.groupFunções.Location = new System.Drawing.Point(1196, 301);
            this.groupFunções.Name = "groupFunções";
            this.groupFunções.Size = new System.Drawing.Size(252, 174);
            this.groupFunções.TabIndex = 89;
            this.groupFunções.TabStop = false;
            this.groupFunções.Text = "Funções";
            // 
            // lllDeletarDados
            // 
            this.lllDeletarDados.AutoSize = true;
            this.lllDeletarDados.Location = new System.Drawing.Point(61, 139);
            this.lllDeletarDados.Name = "lllDeletarDados";
            this.lllDeletarDados.Size = new System.Drawing.Size(80, 15);
            this.lllDeletarDados.TabIndex = 3;
            this.lllDeletarDados.TabStop = true;
            this.lllDeletarDados.Text = "Deletar Dados";
            // 
            // lllModificarDados
            // 
            this.lllModificarDados.AutoSize = true;
            this.lllModificarDados.Location = new System.Drawing.Point(61, 104);
            this.lllModificarDados.Name = "lllModificarDados";
            this.lllModificarDados.Size = new System.Drawing.Size(94, 15);
            this.lllModificarDados.TabIndex = 2;
            this.lllModificarDados.TabStop = true;
            this.lllModificarDados.Text = "Modificar Dados";
            // 
            // lllConsultarTodos
            // 
            this.lllConsultarTodos.AutoSize = true;
            this.lllConsultarTodos.Location = new System.Drawing.Point(61, 71);
            this.lllConsultarTodos.Name = "lllConsultarTodos";
            this.lllConsultarTodos.Size = new System.Drawing.Size(92, 15);
            this.lllConsultarTodos.TabIndex = 1;
            this.lllConsultarTodos.TabStop = true;
            this.lllConsultarTodos.Text = "Consultar Todos";
            // 
            // lllConsultar
            // 
            this.lllConsultar.AutoSize = true;
            this.lllConsultar.Location = new System.Drawing.Point(61, 41);
            this.lllConsultar.Name = "lllConsultar";
            this.lllConsultar.Size = new System.Drawing.Size(58, 15);
            this.lllConsultar.TabIndex = 0;
            this.lllConsultar.TabStop = true;
            this.lllConsultar.Text = "Consultar";
            this.lllConsultar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lllConsultar_LinkClicked);
            // 
            // groupPredio
            // 
            this.groupPredio.Controls.Add(this.btnCadastrar);
            this.groupPredio.Controls.Add(this.lblIdCondominio);
            this.groupPredio.Controls.Add(this.nudNumero);
            this.groupPredio.Controls.Add(this.txtCondominio);
            this.groupPredio.Controls.Add(this.txtNome);
            this.groupPredio.Controls.Add(this.lblCondominio);
            this.groupPredio.Controls.Add(this.lblNumero);
            this.groupPredio.Controls.Add(this.lblNome);
            this.groupPredio.Location = new System.Drawing.Point(695, 301);
            this.groupPredio.Name = "groupPredio";
            this.groupPredio.Size = new System.Drawing.Size(432, 335);
            this.groupPredio.TabIndex = 90;
            this.groupPredio.TabStop = false;
            this.groupPredio.Text = "Prédio";
            // 
            // ucInserir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupPredio);
            this.Controls.Add(this.groupFunções);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mnsCondominio);
            this.Name = "ucInserir";
            this.Size = new System.Drawing.Size(1730, 800);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).EndInit();
            this.mnsCondominio.ResumeLayout(false);
            this.mnsCondominio.PerformLayout();
            this.groupFunções.ResumeLayout(false);
            this.groupFunções.PerformLayout();
            this.groupPredio.ResumeLayout(false);
            this.groupPredio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblCondominio;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCondominio;
        private System.Windows.Forms.NumericUpDown nudNumero;
        private System.Windows.Forms.Label lblIdCondominio;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.MenuStrip mnsCondominio;
        private System.Windows.Forms.ToolStripMenuItem tsmCondomínio;
        private System.Windows.Forms.ToolStripMenuItem tsmPredio;
        private System.Windows.Forms.ToolStripMenuItem tsmMorador;
        private System.Windows.Forms.ToolStripMenuItem tsmApartamento;
        private System.Windows.Forms.ToolStripMenuItem tsmVisitante;
        private System.Windows.Forms.ToolStripMenuItem tsmGaragem;
        private System.Windows.Forms.ToolStripMenuItem tsmVeiculo;
        private System.Windows.Forms.ToolStripMenuItem tsmPrestadorDeServicos;
        private System.Windows.Forms.ToolStripMenuItem tsmSindico;
        private System.Windows.Forms.ToolStripMenuItem tsmHomePage;
        private System.Windows.Forms.ToolStripMenuItem tsmVisita;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupFunções;
        private System.Windows.Forms.LinkLabel lllDeletarDados;
        private System.Windows.Forms.LinkLabel lllModificarDados;
        private System.Windows.Forms.LinkLabel lllConsultarTodos;
        private System.Windows.Forms.LinkLabel lllConsultar;
        private System.Windows.Forms.GroupBox groupPredio;
    }
}
