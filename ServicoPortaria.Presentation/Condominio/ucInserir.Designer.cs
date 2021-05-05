
namespace ServicoPortaria.Presentation.Condominio
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
            this.txtPais = new System.Windows.Forms.TextBox();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtCodPostal = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblCondominio = new System.Windows.Forms.Label();
            this.lblCodPostal = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.mtxCEP = new System.Windows.Forms.MaskedTextBox();
            this.nudNumero = new System.Windows.Forms.NumericUpDown();
            this.lblRua = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.lblClose = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.groupInserir = new System.Windows.Forms.GroupBox();
            this.groupFunções = new System.Windows.Forms.GroupBox();
            this.lllConsultar = new System.Windows.Forms.LinkLabel();
            this.lllConsultarTodos = new System.Windows.Forms.LinkLabel();
            this.lllModificarDados = new System.Windows.Forms.LinkLabel();
            this.lllDeletarDados = new System.Windows.Forms.LinkLabel();
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
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).BeginInit();
            this.groupInserir.SuspendLayout();
            this.groupFunções.SuspendLayout();
            this.mnsCondominio.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(199, 336);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(243, 23);
            this.txtPais.TabIndex = 34;
            // 
            // txtProvincia
            // 
            this.txtProvincia.Location = new System.Drawing.Point(199, 302);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(243, 23);
            this.txtProvincia.TabIndex = 33;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(199, 237);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(243, 23);
            this.txtCidade.TabIndex = 31;
            // 
            // txtCodPostal
            // 
            this.txtCodPostal.Location = new System.Drawing.Point(199, 155);
            this.txtCodPostal.Name = "txtCodPostal";
            this.txtCodPostal.Size = new System.Drawing.Size(243, 23);
            this.txtCodPostal.TabIndex = 28;
            this.txtCodPostal.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(199, 26);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(243, 23);
            this.txtNome.TabIndex = 27;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(41, 339);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(28, 15);
            this.lblPais.TabIndex = 26;
            this.lblPais.Text = "País";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(41, 305);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(56, 15);
            this.lblProvincia.TabIndex = 25;
            this.lblProvincia.Text = "Província";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(41, 273);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(42, 15);
            this.lblEstado.TabIndex = 24;
            this.lblEstado.Text = "Estado";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(41, 237);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(44, 15);
            this.lblCidade.TabIndex = 23;
            this.lblCidade.Text = "Cidade";
            // 
            // lblCondominio
            // 
            this.lblCondominio.AutoSize = true;
            this.lblCondominio.Location = new System.Drawing.Point(41, 201);
            this.lblCondominio.Name = "lblCondominio";
            this.lblCondominio.Size = new System.Drawing.Size(138, 15);
            this.lblCondominio.TabIndex = 22;
            this.lblCondominio.Text = "Número do Condomínio";
            // 
            // lblCodPostal
            // 
            this.lblCodPostal.AutoSize = true;
            this.lblCodPostal.Location = new System.Drawing.Point(41, 158);
            this.lblCodPostal.Name = "lblCodPostal";
            this.lblCodPostal.Size = new System.Drawing.Size(81, 15);
            this.lblCodPostal.TabIndex = 21;
            this.lblCodPostal.Text = "Código Postal";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(41, 74);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(28, 15);
            this.lblCEP.TabIndex = 20;
            this.lblCEP.Text = "CEP";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(41, 29);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 15);
            this.lblNome.TabIndex = 19;
            this.lblNome.Text = "Nome";
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.Blue;
            this.btnInserir.ForeColor = System.Drawing.Color.White;
            this.btnInserir.Location = new System.Drawing.Point(146, 392);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(216, 61);
            this.btnInserir.TabIndex = 35;
            this.btnInserir.Text = "Inserir Dados";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // mtxCEP
            // 
            this.mtxCEP.Location = new System.Drawing.Point(199, 71);
            this.mtxCEP.Mask = "00000-000";
            this.mtxCEP.Name = "mtxCEP";
            this.mtxCEP.Size = new System.Drawing.Size(243, 23);
            this.mtxCEP.TabIndex = 37;
            // 
            // nudNumero
            // 
            this.nudNumero.Location = new System.Drawing.Point(199, 199);
            this.nudNumero.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudNumero.Name = "nudNumero";
            this.nudNumero.Size = new System.Drawing.Size(243, 23);
            this.nudNumero.TabIndex = 39;
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(41, 118);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(27, 15);
            this.lblRua.TabIndex = 40;
            this.lblRua.Text = "Rua";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(199, 115);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(243, 23);
            this.txtRua.TabIndex = 41;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.BackColor = System.Drawing.Color.Red;
            this.lblClose.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(1346, -1);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(24, 25);
            this.lblClose.TabIndex = 45;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.cmbEstado.Location = new System.Drawing.Point(199, 270);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(243, 23);
            this.cmbEstado.TabIndex = 82;
            // 
            // groupInserir
            // 
            this.groupInserir.Controls.Add(this.cmbEstado);
            this.groupInserir.Controls.Add(this.txtRua);
            this.groupInserir.Controls.Add(this.lblRua);
            this.groupInserir.Controls.Add(this.nudNumero);
            this.groupInserir.Controls.Add(this.mtxCEP);
            this.groupInserir.Controls.Add(this.btnInserir);
            this.groupInserir.Controls.Add(this.txtPais);
            this.groupInserir.Controls.Add(this.txtProvincia);
            this.groupInserir.Controls.Add(this.txtCidade);
            this.groupInserir.Controls.Add(this.txtCodPostal);
            this.groupInserir.Controls.Add(this.txtNome);
            this.groupInserir.Controls.Add(this.lblPais);
            this.groupInserir.Controls.Add(this.lblProvincia);
            this.groupInserir.Controls.Add(this.lblEstado);
            this.groupInserir.Controls.Add(this.lblCidade);
            this.groupInserir.Controls.Add(this.lblCondominio);
            this.groupInserir.Controls.Add(this.lblCodPostal);
            this.groupInserir.Controls.Add(this.lblCEP);
            this.groupInserir.Controls.Add(this.lblNome);
            this.groupInserir.Location = new System.Drawing.Point(190, 126);
            this.groupInserir.Name = "groupInserir";
            this.groupInserir.Size = new System.Drawing.Size(491, 486);
            this.groupInserir.TabIndex = 83;
            this.groupInserir.TabStop = false;
            this.groupInserir.Text = "Inserir";
            // 
            // groupFunções
            // 
            this.groupFunções.Controls.Add(this.lllDeletarDados);
            this.groupFunções.Controls.Add(this.lllModificarDados);
            this.groupFunções.Controls.Add(this.lllConsultarTodos);
            this.groupFunções.Controls.Add(this.lllConsultar);
            this.groupFunções.Location = new System.Drawing.Point(701, 126);
            this.groupFunções.Name = "groupFunções";
            this.groupFunções.Size = new System.Drawing.Size(252, 174);
            this.groupFunções.TabIndex = 84;
            this.groupFunções.TabStop = false;
            this.groupFunções.Text = "Funções";
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
            // lllConsultarTodos
            // 
            this.lllConsultarTodos.AutoSize = true;
            this.lllConsultarTodos.Location = new System.Drawing.Point(61, 71);
            this.lllConsultarTodos.Name = "lllConsultarTodos";
            this.lllConsultarTodos.Size = new System.Drawing.Size(92, 15);
            this.lllConsultarTodos.TabIndex = 1;
            this.lllConsultarTodos.TabStop = true;
            this.lllConsultarTodos.Text = "Consultar Todos";
            this.lllConsultarTodos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lllConsultarTodos_LinkClicked);
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
            this.lllModificarDados.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lllModificarDados_LinkClicked);
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
            this.lllDeletarDados.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lllDeletarDados_LinkClicked);
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
            this.mnsCondominio.Size = new System.Drawing.Size(1370, 24);
            this.mnsCondominio.TabIndex = 85;
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
            this.label1.Location = new System.Drawing.Point(1345, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 25);
            this.label1.TabIndex = 87;
            this.label1.Text = "X";
            // 
            // ucInserir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mnsCondominio);
            this.Controls.Add(this.groupFunções);
            this.Controls.Add(this.groupInserir);
            this.Controls.Add(this.lblClose);
            this.Name = "ucInserir";
            this.Size = new System.Drawing.Size(1370, 749);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).EndInit();
            this.groupInserir.ResumeLayout(false);
            this.groupInserir.PerformLayout();
            this.groupFunções.ResumeLayout(false);
            this.groupFunções.PerformLayout();
            this.mnsCondominio.ResumeLayout(false);
            this.mnsCondominio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtCodPostal;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblCondominio;
        private System.Windows.Forms.Label lblCodPostal;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.MaskedTextBox mtxCEP;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.NumericUpDown nudNumero;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.GroupBox groupInserir;
        private System.Windows.Forms.GroupBox groupFunções;
        private System.Windows.Forms.LinkLabel lllDeletarDados;
        private System.Windows.Forms.LinkLabel lllModificarDados;
        private System.Windows.Forms.LinkLabel lllConsultarTodos;
        private System.Windows.Forms.LinkLabel lllConsultar;
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
    }
}
