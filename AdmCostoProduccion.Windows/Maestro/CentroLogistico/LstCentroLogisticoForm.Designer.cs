﻿namespace AdmCostoProduccion.Windows.Maestro.CentroLogistico
{
    partial class LstCentroLogisticoForm
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
            this.SuspendLayout();
            // 
            // LstCentroLogisticoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 425);
            this.Name = "LstCentroLogisticoForm";
            this.Text = "Centro Logístico";
            this.Agregar += new System.EventHandler(this.LstCentroLogisticoForm_Agregar);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}