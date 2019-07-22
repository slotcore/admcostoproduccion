﻿namespace AdmCostoProduccion.Windows.Maestro.PlantaFabricacion
{
    partial class MntPlantaFabricacionForm
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
            System.Windows.Forms.Label centroLogisticoIdLabel;
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label nombreLabel;
            this.BaseFormHeaderGroup = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.centroLogisticoIdComboBox = new System.Windows.Forms.ComboBox();
            this.plantaFabricacionViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.centroLogisticoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.BaseFormToolStrip = new System.Windows.Forms.ToolStrip();
            this.GrabarButton = new System.Windows.Forms.ToolStripButton();
            this.CancelarButton = new System.Windows.Forms.ToolStripButton();
            centroLogisticoIdLabel = new System.Windows.Forms.Label();
            codigoLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup.Panel)).BeginInit();
            this.BaseFormHeaderGroup.Panel.SuspendLayout();
            this.BaseFormHeaderGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plantaFabricacionViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centroLogisticoBindingSource)).BeginInit();
            this.BaseFormToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // centroLogisticoIdLabel
            // 
            centroLogisticoIdLabel.AutoSize = true;
            centroLogisticoIdLabel.BackColor = System.Drawing.Color.Transparent;
            centroLogisticoIdLabel.Location = new System.Drawing.Point(202, 127);
            centroLogisticoIdLabel.Name = "centroLogisticoIdLabel";
            centroLogisticoIdLabel.Size = new System.Drawing.Size(88, 13);
            centroLogisticoIdLabel.TabIndex = 0;
            centroLogisticoIdLabel.Text = "Centro Logístico:";
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.BackColor = System.Drawing.Color.Transparent;
            codigoLabel.Location = new System.Drawing.Point(202, 154);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(43, 13);
            codigoLabel.TabIndex = 2;
            codigoLabel.Text = "Codigo:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.BackColor = System.Drawing.Color.Transparent;
            descripcionLabel.Location = new System.Drawing.Point(202, 206);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 6;
            descripcionLabel.Text = "Descripcion:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.BackColor = System.Drawing.Color.Transparent;
            nombreLabel.Location = new System.Drawing.Point(202, 180);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 4;
            nombreLabel.Text = "Nombre:";
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
            this.BaseFormHeaderGroup.TabIndex = 7;
            this.BaseFormHeaderGroup.ValuesPrimary.Heading = "Planta de Fabricación";
            this.BaseFormHeaderGroup.ValuesPrimary.Image = null;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(centroLogisticoIdLabel);
            this.kryptonPanel1.Controls.Add(this.centroLogisticoIdComboBox);
            this.kryptonPanel1.Controls.Add(codigoLabel);
            this.kryptonPanel1.Controls.Add(this.codigoTextBox);
            this.kryptonPanel1.Controls.Add(descripcionLabel);
            this.kryptonPanel1.Controls.Add(this.descripcionTextBox);
            this.kryptonPanel1.Controls.Add(nombreLabel);
            this.kryptonPanel1.Controls.Add(this.nombreTextBox);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(798, 395);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // centroLogisticoIdComboBox
            // 
            this.centroLogisticoIdComboBox.CausesValidation = false;
            this.centroLogisticoIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantaFabricacionViewModelBindingSource, "CentroLogisticoId", true));
            this.centroLogisticoIdComboBox.DataSource = this.centroLogisticoBindingSource;
            this.centroLogisticoIdComboBox.DisplayMember = "Nombre";
            this.centroLogisticoIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.centroLogisticoIdComboBox.FormattingEnabled = true;
            this.centroLogisticoIdComboBox.Location = new System.Drawing.Point(306, 124);
            this.centroLogisticoIdComboBox.Name = "centroLogisticoIdComboBox";
            this.centroLogisticoIdComboBox.Size = new System.Drawing.Size(291, 21);
            this.centroLogisticoIdComboBox.TabIndex = 1;
            this.centroLogisticoIdComboBox.ValueMember = "CentroLogisticoId";
            // 
            // plantaFabricacionViewModelBindingSource
            // 
            this.plantaFabricacionViewModelBindingSource.DataSource = typeof(AdmCostoProduccion.Common.ViewModels.Maestro.PlantaFabricacionViewModel);
            // 
            // centroLogisticoBindingSource
            // 
            this.centroLogisticoBindingSource.DataSource = typeof(AdmCostoProduccion.Common.Models.Maestro.CentroLogistico);
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantaFabricacionViewModelBindingSource, "Codigo", true));
            this.codigoTextBox.Location = new System.Drawing.Point(306, 151);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(291, 20);
            this.codigoTextBox.TabIndex = 3;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantaFabricacionViewModelBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(306, 203);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(291, 20);
            this.descripcionTextBox.TabIndex = 7;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantaFabricacionViewModelBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(306, 177);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(291, 20);
            this.nombreTextBox.TabIndex = 5;
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
            this.BaseFormToolStrip.TabIndex = 6;
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
            // MntPlantaFabricacionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BaseFormHeaderGroup);
            this.Controls.Add(this.BaseFormToolStrip);
            this.Name = "MntPlantaFabricacionForm";
            this.Text = "Mantenimiento Planta de Fabricación";
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup.Panel)).EndInit();
            this.BaseFormHeaderGroup.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup)).EndInit();
            this.BaseFormHeaderGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plantaFabricacionViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centroLogisticoBindingSource)).EndInit();
            this.BaseFormToolStrip.ResumeLayout(false);
            this.BaseFormToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup BaseFormHeaderGroup;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        protected System.Windows.Forms.ToolStrip BaseFormToolStrip;
        private System.Windows.Forms.ToolStripButton GrabarButton;
        private System.Windows.Forms.ToolStripButton CancelarButton;
        private System.Windows.Forms.ComboBox centroLogisticoIdComboBox;
        private System.Windows.Forms.BindingSource plantaFabricacionViewModelBindingSource;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.BindingSource centroLogisticoBindingSource;
    }
}