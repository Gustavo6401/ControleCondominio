
namespace ServicoPortaria.Presentation.Condominio.Forms
{
    partial class frmModificar
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
            this.ucModificar = new ucModificar();
            //
            // ucModificar
            //
            this.ucModificar.BackColor = System.Drawing.Color.White;
            this.ucModificar.Location = new System.Drawing.Point(0, 0);
            this.ucModificar.Name = "ucModificar";
            this.Size = new System.Drawing.Size(1370, 800);
            this.ucModificar.TabIndex = 0;
            //
            // frmModificar
            //
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 800);
            this.Controls.Add(ucModificar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Text = "frmModificar";
        }

        #endregion

        private ucModificar ucModificar;
    }
}