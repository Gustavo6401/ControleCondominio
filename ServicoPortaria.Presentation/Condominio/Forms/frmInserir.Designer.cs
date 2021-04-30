
using System;

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
            this.Inserir = new ucnInserir();
            this.SuspendLayout();
            // 
            // frmInserir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 800);
            this.Controls.Add(this.Inserir);
            this.Name = "frmInserir";
            this.Text = "frmInserir";
            this.ResumeLayout(false);
            //
            // ucnInserir
            //
            this.Inserir.BackColor = System.Drawing.Color.White;
            this.Inserir.Location = new System.Drawing.Point(1, 1);
            this.Inserir.Name = "ucnInserir";
            this.Inserir.Size = new System.Drawing.Size(1370, 800);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Inserir.TabIndex = 0;
            this.Inserir.Load += new System.EventHandler(this.ucInserir_Load);
        }        

        #endregion

        private ucnInserir Inserir;
    }
}