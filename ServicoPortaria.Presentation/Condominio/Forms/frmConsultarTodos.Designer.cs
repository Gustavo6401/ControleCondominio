using ServicoPortaria.Presentation.Condominio;

namespace ServicoPortaria.Presentation.Condominio.Forms
{
    partial class frmConsultarTodos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListarTodos = new ServicoPortaria.Presentation.Condominio.ucListarTodos();
            this.SuspendLayout();
            // 
            // ListarTodos
            // 
            this.ListarTodos.BackColor = System.Drawing.Color.White;
            this.ListarTodos.Location = new System.Drawing.Point(1, 1);
            this.ListarTodos.Name = "ListarTodos";
            this.ListarTodos.Size = new System.Drawing.Size(1370, 800);
            this.ListarTodos.TabIndex = 0;
            this.ListarTodos.Load += new System.EventHandler(this.ListarTodos_Load);
            // 
            // frmConsultarTodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 800);
            this.Controls.Add(this.ListarTodos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultarTodos";
            this.Text = "frmConsultarTodos";
            this.ResumeLayout(false);

        }

        #endregion

        public ucListarTodos ListarTodos;
    }
}