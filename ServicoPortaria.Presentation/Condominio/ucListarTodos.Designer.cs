
namespace ServicoPortaria.Presentation.Condominio
{
    partial class ucListarTodos
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
            this.mnsCondominio = new System.Windows.Forms.MenuStrip();
            this.tsmCondominio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmInserir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConsultarComId = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConsultarTodos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.lblClose = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.lblPresentation = new System.Windows.Forms.Label();
            this.mnsCondominio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
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
            this.tsmUpdate,
            this.tsmRemove});
            this.mnsCondominio.Location = new System.Drawing.Point(0, 0);
            this.mnsCondominio.Name = "mnsCondominio";
            this.mnsCondominio.Size = new System.Drawing.Size(1370, 24);
            this.mnsCondominio.TabIndex = 38;
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
            this.tsmInserir.Click += new System.EventHandler(this.tsmInserir_Click);
            // 
            // tsmConsultar
            // 
            this.tsmConsultar.ForeColor = System.Drawing.Color.White;
            this.tsmConsultar.Name = "tsmConsultar";
            this.tsmConsultar.Size = new System.Drawing.Size(70, 20);
            this.tsmConsultar.Text = "Consultar";
            this.tsmConsultar.Click += new System.EventHandler(this.tsmConsultar_Click);
            // 
            // tsmConsultarComId
            // 
            this.tsmConsultarComId.ForeColor = System.Drawing.Color.White;
            this.tsmConsultarComId.Name = "tsmConsultarComId";
            this.tsmConsultarComId.Size = new System.Drawing.Size(141, 20);
            this.tsmConsultarComId.Text = "Consultar Com Código";
            this.tsmConsultarComId.Click += new System.EventHandler(this.tsmConsultarComId_Click);
            // 
            // tsmConsultarTodos
            // 
            this.tsmConsultarTodos.Enabled = false;
            this.tsmConsultarTodos.ForeColor = System.Drawing.Color.White;
            this.tsmConsultarTodos.Name = "tsmConsultarTodos";
            this.tsmConsultarTodos.Size = new System.Drawing.Size(104, 20);
            this.tsmConsultarTodos.Text = "Consultar Todos";
            // 
            // tsmUpdate
            // 
            this.tsmUpdate.ForeColor = System.Drawing.Color.White;
            this.tsmUpdate.Name = "tsmUpdate";
            this.tsmUpdate.Size = new System.Drawing.Size(106, 20);
            this.tsmUpdate.Text = "Modificar Dados";
            this.tsmUpdate.Click += new System.EventHandler(this.tsmUpdate_Click);
            // 
            // tsmRemove
            // 
            this.tsmRemove.ForeColor = System.Drawing.Color.White;
            this.tsmRemove.Name = "tsmRemove";
            this.tsmRemove.Size = new System.Drawing.Size(92, 20);
            this.tsmRemove.Text = "Deletar Dados";
            this.tsmRemove.Click += new System.EventHandler(this.tsmRemove_Click);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.BackColor = System.Drawing.Color.Red;
            this.lblClose.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(1345, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(24, 25);
            this.lblClose.TabIndex = 39;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToResizeColumns = false;
            this.dgvData.AllowUserToResizeRows = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(386, 240);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowTemplate.Height = 25;
            this.dgvData.Size = new System.Drawing.Size(545, 290);
            this.dgvData.TabIndex = 40;
            // 
            // lblPresentation
            // 
            this.lblPresentation.AutoSize = true;
            this.lblPresentation.Location = new System.Drawing.Point(505, 222);
            this.lblPresentation.Name = "lblPresentation";
            this.lblPresentation.Size = new System.Drawing.Size(299, 15);
            this.lblPresentation.TabIndex = 41;
            this.lblPresentation.Text = "Olá, seja muito bem vindo ao módulo de condomínios!";
            // 
            // ucListarTodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPresentation);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.mnsCondominio);
            this.Name = "ucListarTodos";
            this.Size = new System.Drawing.Size(1370, 800);
            this.Load += new System.EventHandler(this.ucListarTodos_Load);
            this.mnsCondominio.ResumeLayout(false);
            this.mnsCondominio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsCondominio;
        private System.Windows.Forms.ToolStripMenuItem tsmCondominio;
        private System.Windows.Forms.ToolStripMenuItem tsmInserir;
        private System.Windows.Forms.ToolStripMenuItem tsmConsultar;
        private System.Windows.Forms.ToolStripMenuItem tsmConsultarComId;
        private System.Windows.Forms.ToolStripMenuItem tsmConsultarTodos;
        private System.Windows.Forms.ToolStripMenuItem tsmUpdate;
        private System.Windows.Forms.ToolStripMenuItem tsmRemove;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label lblPresentation;
    }
}
