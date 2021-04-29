
namespace ServicoPortaria.Presentation.Condominio.Forms
{
    partial class frmInserir
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
            this.ucnInserir1 = new ServicoPortaria.Presentation.Condominio.ucnInserir();
            this.SuspendLayout();
            // 
            // ucnInserir1
            // 
            this.ucnInserir1.Location = new System.Drawing.Point(1, -1);
            this.ucnInserir1.Name = "ucnInserir1";
            this.ucnInserir1.Size = new System.Drawing.Size(624, 487);
            this.ucnInserir1.TabIndex = 0;
            // 
            // frmInserir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 484);
            this.Controls.Add(this.ucnInserir1);
            this.Name = "frmInserir";
            this.Text = "frmInserir";
            this.ResumeLayout(false);

        }

        #endregion

        private ucnInserir ucnInserir1;
    }
}