﻿namespace AdmCostoProduccion.Windows.Mantenimiento.Aplicacion.AplicacionCorrelativo
{
    partial class MntAplicacionCorrelativoForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label correlativoLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label numeroDigitosLabel;
            System.Windows.Forms.Label prefijoLabel;
            this.BaseFormHeaderGroup = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.BaseFormToolStrip = new System.Windows.Forms.ToolStrip();
            this.GrabarButton = new System.Windows.Forms.ToolStripButton();
            this.CancelarButton = new System.Windows.Forms.ToolStripButton();
            this.aplicacionCorrelativoViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.correlativoTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.numeroDigitosTextBox = new System.Windows.Forms.TextBox();
            this.prefijoTextBox = new System.Windows.Forms.TextBox();
            codigoLabel = new System.Windows.Forms.Label();
            correlativoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            numeroDigitosLabel = new System.Windows.Forms.Label();
            prefijoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup.Panel)).BeginInit();
            this.BaseFormHeaderGroup.Panel.SuspendLayout();
            this.BaseFormHeaderGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.BaseFormToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aplicacionCorrelativoViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BaseFormHeaderGroup
            // 
            this.BaseFormHeaderGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BaseFormHeaderGroup.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Calendar;
            this.BaseFormHeaderGroup.HeaderStyleSecondary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Form;
            this.BaseFormHeaderGroup.HeaderVisibleSecondary = false;
            this.BaseFormHeaderGroup.Location = new System.Drawing.Point(0, 31);
            this.BaseFormHeaderGroup.Margin = new System.Windows.Forms.Padding(2);
            this.BaseFormHeaderGroup.Name = "BaseFormHeaderGroup";
            // 
            // BaseFormHeaderGroup.Panel
            // 
            this.BaseFormHeaderGroup.Panel.Controls.Add(this.kryptonPanel1);
            this.BaseFormHeaderGroup.Size = new System.Drawing.Size(800, 419);
            this.BaseFormHeaderGroup.StateNormal.HeaderPrimary.Border.Color1 = System.Drawing.SystemColors.ControlDarkDark;
            this.BaseFormHeaderGroup.StateNormal.HeaderPrimary.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.BaseFormHeaderGroup.StateNormal.HeaderPrimary.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.BaseFormHeaderGroup.StateNormal.HeaderPrimary.Border.Width = 1;
            this.BaseFormHeaderGroup.TabIndex = 17;
            this.BaseFormHeaderGroup.ValuesPrimary.Heading = "Mantenimiento de Correlativo";
            this.BaseFormHeaderGroup.ValuesPrimary.Image = null;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(codigoLabel);
            this.kryptonPanel1.Controls.Add(this.codigoTextBox);
            this.kryptonPanel1.Controls.Add(correlativoLabel);
            this.kryptonPanel1.Controls.Add(this.correlativoTextBox);
            this.kryptonPanel1.Controls.Add(nombreLabel);
            this.kryptonPanel1.Controls.Add(this.nombreTextBox);
            this.kryptonPanel1.Controls.Add(numeroDigitosLabel);
            this.kryptonPanel1.Controls.Add(this.numeroDigitosTextBox);
            this.kryptonPanel1.Controls.Add(prefijoLabel);
            this.kryptonPanel1.Controls.Add(this.prefijoTextBox);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(798, 395);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // BaseFormToolStrip
            // 
            this.BaseFormToolStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BaseFormToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.BaseFormToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.BaseFormToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GrabarButton,
            this.CancelarButton});
            this.BaseFormToolStrip.Location = new System.Drawing.Point(0, 0);
            this.BaseFormToolStrip.Name = "BaseFormToolStrip";
            this.BaseFormToolStrip.Padding = new System.Windows.Forms.Padding(2);
            this.BaseFormToolStrip.Size = new System.Drawing.Size(800, 31);
            this.BaseFormToolStrip.TabIndex = 16;
            this.BaseFormToolStrip.Text = "BaseFormToolStrip";
            // 
            // GrabarButton
            // 
            this.GrabarButton.Image = global::AdmCostoProduccion.Windows.Properties.Resources.save_16x16;
            this.GrabarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GrabarButton.Name = "GrabarButton";
            this.GrabarButton.Size = new System.Drawing.Size(66, 24);
            this.GrabarButton.Text = "Grabar";
            this.GrabarButton.Click += new System.EventHandler(this.GrabarButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.Image = global::AdmCostoProduccion.Windows.Properties.Resources.cancel_16x16;
            this.CancelarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(77, 24);
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // aplicacionCorrelativoViewModelBindingSource
            // 
            this.aplicacionCorrelativoViewModelBindingSource.DataSource = typeof(AdmCostoProduccion.Common.ViewModels.Aplicacion.AplicacionCorrelativoViewModel);
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.BackColor = System.Drawing.Color.Transparent;
            codigoLabel.Location = new System.Drawing.Point(197, 119);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(43, 13);
            codigoLabel.TabIndex = 0;
            codigoLabel.Text = "Codigo:";
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aplicacionCorrelativoViewModelBindingSource, "Codigo", true));
            this.codigoTextBox.Location = new System.Drawing.Point(285, 116);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(305, 20);
            this.codigoTextBox.TabIndex = 1;
            // 
            // correlativoLabel
            // 
            correlativoLabel.AutoSize = true;
            correlativoLabel.BackColor = System.Drawing.Color.Transparent;
            correlativoLabel.Location = new System.Drawing.Point(197, 145);
            correlativoLabel.Name = "correlativoLabel";
            correlativoLabel.Size = new System.Drawing.Size(60, 13);
            correlativoLabel.TabIndex = 2;
            correlativoLabel.Text = "Correlativo:";
            // 
            // correlativoTextBox
            // 
            this.correlativoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aplicacionCorrelativoViewModelBindingSource, "Correlativo", true));
            this.correlativoTextBox.Location = new System.Drawing.Point(285, 142);
            this.correlativoTextBox.Name = "correlativoTextBox";
            this.correlativoTextBox.Size = new System.Drawing.Size(305, 20);
            this.correlativoTextBox.TabIndex = 3;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.BackColor = System.Drawing.Color.Transparent;
            nombreLabel.Location = new System.Drawing.Point(197, 171);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 4;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aplicacionCorrelativoViewModelBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(285, 168);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(305, 20);
            this.nombreTextBox.TabIndex = 5;
            // 
            // numeroDigitosLabel
            // 
            numeroDigitosLabel.AutoSize = true;
            numeroDigitosLabel.BackColor = System.Drawing.Color.Transparent;
            numeroDigitosLabel.Location = new System.Drawing.Point(197, 197);
            numeroDigitosLabel.Name = "numeroDigitosLabel";
            numeroDigitosLabel.Size = new System.Drawing.Size(82, 13);
            numeroDigitosLabel.TabIndex = 6;
            numeroDigitosLabel.Text = "Numero Digitos:";
            // 
            // numeroDigitosTextBox
            // 
            this.numeroDigitosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aplicacionCorrelativoViewModelBindingSource, "NumeroDigitos", true));
            this.numeroDigitosTextBox.Location = new System.Drawing.Point(285, 194);
            this.numeroDigitosTextBox.Name = "numeroDigitosTextBox";
            this.numeroDigitosTextBox.Size = new System.Drawing.Size(305, 20);
            this.numeroDigitosTextBox.TabIndex = 7;
            // 
            // prefijoLabel
            // 
            prefijoLabel.AutoSize = true;
            prefijoLabel.BackColor = System.Drawing.Color.Transparent;
            prefijoLabel.Location = new System.Drawing.Point(197, 223);
            prefijoLabel.Name = "prefijoLabel";
            prefijoLabel.Size = new System.Drawing.Size(39, 13);
            prefijoLabel.TabIndex = 8;
            prefijoLabel.Text = "Prefijo:";
            // 
            // prefijoTextBox
            // 
            this.prefijoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aplicacionCorrelativoViewModelBindingSource, "Prefijo", true));
            this.prefijoTextBox.Location = new System.Drawing.Point(285, 220);
            this.prefijoTextBox.Name = "prefijoTextBox";
            this.prefijoTextBox.Size = new System.Drawing.Size(305, 20);
            this.prefijoTextBox.TabIndex = 9;
            // 
            // MntAplicacionCorrelativoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BaseFormHeaderGroup);
            this.Controls.Add(this.BaseFormToolStrip);
            this.Name = "MntAplicacionCorrelativoForm";
            this.Text = "Mantenimiento de Correlativo";
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup.Panel)).EndInit();
            this.BaseFormHeaderGroup.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup)).EndInit();
            this.BaseFormHeaderGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.BaseFormToolStrip.ResumeLayout(false);
            this.BaseFormToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aplicacionCorrelativoViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup BaseFormHeaderGroup;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        protected System.Windows.Forms.ToolStrip BaseFormToolStrip;
        private System.Windows.Forms.ToolStripButton GrabarButton;
        private System.Windows.Forms.ToolStripButton CancelarButton;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.BindingSource aplicacionCorrelativoViewModelBindingSource;
        private System.Windows.Forms.TextBox correlativoTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox numeroDigitosTextBox;
        private System.Windows.Forms.TextBox prefijoTextBox;
    }
}