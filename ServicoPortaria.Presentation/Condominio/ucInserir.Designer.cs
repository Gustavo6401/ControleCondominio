
namespace ServicoPortaria.Presentation.Condominio
{
    partial class ucnInserir
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
            this.txtEstado = new System.Windows.Forms.TextBox();
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
            this.mnsCondominio = new System.Windows.Forms.MenuStrip();
            this.tsmCondominio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmInserir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConsultarComId = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConsultarTodos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.mtxCEP = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudNumero = new System.Windows.Forms.NumericUpDown();
            this.mnsCondominio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(332, 363);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(123, 23);
            this.txtPais.TabIndex = 34;
            // 
            // txtProvincia
            // 
            this.txtProvincia.Location = new System.Drawing.Point(332, 329);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(123, 23);
            this.txtProvincia.TabIndex = 33;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(332, 297);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(123, 23);
            this.txtEstado.TabIndex = 32;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(332, 264);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(123, 23);
            this.txtCidade.TabIndex = 31;
            // 
            // txtCodPostal
            // 
            this.txtCodPostal.Location = new System.Drawing.Point(335, 182);
            this.txtCodPostal.Name = "txtCodPostal";
            this.txtCodPostal.Size = new System.Drawing.Size(123, 23);
            this.txtCodPostal.TabIndex = 28;
            this.txtCodPostal.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(335, 108);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(123, 23);
            this.txtNome.TabIndex = 27;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(174, 366);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(28, 15);
            this.lblPais.TabIndex = 26;
            this.lblPais.Text = "País";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(174, 332);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(56, 15);
            this.lblProvincia.TabIndex = 25;
            this.lblProvincia.Text = "Província";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(174, 300);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(42, 15);
            this.lblEstado.TabIndex = 24;
            this.lblEstado.Text = "Estado";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(174, 264);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(44, 15);
            this.lblCidade.TabIndex = 23;
            this.lblCidade.Text = "Cidade";
            // 
            // lblCondominio
            // 
            this.lblCondominio.AutoSize = true;
            this.lblCondominio.Location = new System.Drawing.Point(174, 228);
            this.lblCondominio.Name = "lblCondominio";
            this.lblCondominio.Size = new System.Drawing.Size(138, 15);
            this.lblCondominio.TabIndex = 22;
            this.lblCondominio.Text = "Número do Condomínio";
            // 
            // lblCodPostal
            // 
            this.lblCodPostal.AutoSize = true;
            this.lblCodPostal.Location = new System.Drawing.Point(174, 185);
            this.lblCodPostal.Name = "lblCodPostal";
            this.lblCodPostal.Size = new System.Drawing.Size(81, 15);
            this.lblCodPostal.TabIndex = 21;
            this.lblCodPostal.Text = "Código Postal";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(174, 148);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(28, 15);
            this.lblCEP.TabIndex = 20;
            this.lblCEP.Text = "CEP";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(174, 111);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 15);
            this.lblNome.TabIndex = 19;
            this.lblNome.Text = "Nome";
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.Blue;
            this.btnInserir.ForeColor = System.Drawing.Color.White;
            this.btnInserir.Location = new System.Drawing.Point(223, 417);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(193, 47);
            this.btnInserir.TabIndex = 35;
            this.btnInserir.Text = "Inserir Dados";
            this.btnInserir.UseVisualStyleBackColor = false;
            // 
            // mnsCondominio
            // 
            this.mnsCondominio.BackColor = System.Drawing.Color.Black;
            this.mnsCondominio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCondominio,
            this.tsmInserir,
            this.tsmConsultar,
            this.tsmConsultarComId,
            this.tsmConsultarTodos,
            this.tsmUpdate});
            this.mnsCondominio.Location = new System.Drawing.Point(0, 0);
            this.mnsCondominio.Name = "mnsCondominio";
            this.mnsCondominio.Size = new System.Drawing.Size(622, 24);
            this.mnsCondominio.TabIndex = 36;
            this.mnsCondominio.Text = "Condomínio";
            // 
            // tsmCondominio
            // 
            this.tsmCondominio.ForeColor = System.Drawing.Color.White;
            this.tsmCondominio.Name = "tsmCondominio";
            this.tsmCondominio.Size = new System.Drawing.Size(86, 20);
            this.tsmCondominio.Text = "Condomínio";
            // 
            // tsmInserir
            // 
            this.tsmInserir.ForeColor = System.Drawing.Color.White;
            this.tsmInserir.Name = "tsmInserir";
            this.tsmInserir.Size = new System.Drawing.Size(51, 20);
            this.tsmInserir.Text = "Inserir";
            // 
            // tsmConsultar
            // 
            this.tsmConsultar.ForeColor = System.Drawing.Color.White;
            this.tsmConsultar.Name = "tsmConsultar";
            this.tsmConsultar.Size = new System.Drawing.Size(70, 20);
            this.tsmConsultar.Text = "Consultar";
            // 
            // tsmConsultarComId
            // 
            this.tsmConsultarComId.ForeColor = System.Drawing.Color.White;
            this.tsmConsultarComId.Name = "tsmConsultarComId";
            this.tsmConsultarComId.Size = new System.Drawing.Size(141, 20);
            this.tsmConsultarComId.Text = "Consultar Com Código";
            // 
            // tsmConsultarTodos
            // 
            this.tsmConsultarTodos.ForeColor = System.Drawing.Color.White;
            this.tsmConsultarTodos.Name = "tsmConsultarTodos";
            this.tsmConsultarTodos.Size = new System.Drawing.Size(101, 20);
            this.tsmConsultarTodos.Text = "ConsultarTodos";
            // 
            // tsmUpdate
            // 
            this.tsmUpdate.ForeColor = System.Drawing.Color.White;
            this.tsmUpdate.Name = "tsmUpdate";
            this.tsmUpdate.Size = new System.Drawing.Size(106, 20);
            this.tsmUpdate.Text = "Modificar Dados";
            // 
            // mtxCEP
            // 
            this.mtxCEP.Location = new System.Drawing.Point(335, 145);
            this.mtxCEP.Mask = "00.000-00";
            this.mtxCEP.Name = "mtxCEP";
            this.mtxCEP.Size = new System.Drawing.Size(123, 23);
            this.mtxCEP.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(599, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "X";
            // 
            // nudNumero
            // 
            this.nudNumero.Location = new System.Drawing.Point(335, 226);
            this.nudNumero.Name = "nudNumero";
            this.nudNumero.Size = new System.Drawing.Size(123, 23);
            this.nudNumero.TabIndex = 39;
            // 
            // ucnInserir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nudNumero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtxCEP);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.txtProvincia);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtCodPostal);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lblProvincia);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblCondominio);
            this.Controls.Add(this.lblCodPostal);
            this.Controls.Add(this.lblCEP);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.mnsCondominio);
            this.Name = "ucnInserir";
            this.Size = new System.Drawing.Size(622, 476);
            this.mnsCondominio.ResumeLayout(false);
            this.mnsCondominio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.TextBox txtEstado;
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
        private System.Windows.Forms.MenuStrip mnsCondominio;
        private System.Windows.Forms.ToolStripMenuItem tsmCondominio;
        private System.Windows.Forms.ToolStripMenuItem tsmInserir;
        private System.Windows.Forms.ToolStripMenuItem tsmConsultar;
        private System.Windows.Forms.ToolStripMenuItem tsmConsultarComId;
        private System.Windows.Forms.ToolStripMenuItem tsmConsultarTodos;
        private System.Windows.Forms.ToolStripMenuItem tsmUpdate;
        private System.Windows.Forms.MaskedTextBox mtxCEP;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudNumero;
    }
}
