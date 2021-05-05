
namespace ServicoPortaria.Presentation.Predio.Forms
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
            this.ucInserir = new ucInserir();
            this.SuspendLayout();
            //
            // ucInserir
            //
            this.ucInserir.BackColor = System.Drawing.Color.White;
            this.ucInserir.Location = new System.Drawing.Point(1, 1);
            this.ucInserir.Name = "ucInserir";
            this.ucInserir.Size = new System.Drawing.Size(1370, 800);
            this.ucInserir.TabIndex = 0;
            // 
            // frmInserir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 800);
            this.Controls.Add(ucInserir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInserir";
            this.Text = "frmInserir";
            this.ResumeLayout(false);

        }

        #endregion

        private ucInserir ucInserir;
    }
}