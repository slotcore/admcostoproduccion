﻿namespace AdmCostoProduccion.Windows.Mantenimiento.Inventario.Mercaderia
{
    partial class MntMercaderiaForm
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
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label tipoMercaderiaIdLabel;
            System.Windows.Forms.Label familiaMercaderiaIdLabel;
            this.BaseFormHeaderGroup = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.familiaMercaderiaIdComboBox = new System.Windows.Forms.ComboBox();
            this.mercaderiaViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.familiaMercaderiaViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.tipoMercaderiaIdComboBox = new System.Windows.Forms.ComboBox();
            this.tipoMercaderiaViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BaseFormToolStrip = new System.Windows.Forms.ToolStrip();
            this.GrabarButton = new System.Windows.Forms.ToolStripButton();
            this.CancelarButton = new System.Windows.Forms.ToolStripButton();
            codigoLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            tipoMercaderiaIdLabel = new System.Windows.Forms.Label();
            familiaMercaderiaIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup.Panel)).BeginInit();
            this.BaseFormHeaderGroup.Panel.SuspendLayout();
            this.BaseFormHeaderGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mercaderiaViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familiaMercaderiaViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoMercaderiaViewModelBindingSource)).BeginInit();
            this.BaseFormToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.BackColor = System.Drawing.Color.Transparent;
            codigoLabel.Location = new System.Drawing.Point(197, 219);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(56, 17);
            codigoLabel.TabIndex = 4;
            codigoLabel.Text = "Codigo:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.BackColor = System.Drawing.Color.Transparent;
            descripcionLabel.Location = new System.Drawing.Point(197, 276);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(86, 17);
            descripcionLabel.TabIndex = 8;
            descripcionLabel.Text = "Descripcion:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.BackColor = System.Drawing.Color.Transparent;
            nombreLabel.Location = new System.Drawing.Point(197, 247);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(62, 17);
            nombreLabel.TabIndex = 6;
            nombreLabel.Text = "Nombre:";
            // 
            // tipoMercaderiaIdLabel
            // 
            tipoMercaderiaIdLabel.AutoSize = true;
            tipoMercaderiaIdLabel.BackColor = System.Drawing.Color.Transparent;
            tipoMercaderiaIdLabel.Location = new System.Drawing.Point(197, 162);
            tipoMercaderiaIdLabel.Name = "tipoMercaderiaIdLabel";
            tipoMercaderiaIdLabel.Size = new System.Drawing.Size(115, 17);
            tipoMercaderiaIdLabel.TabIndex = 0;
            tipoMercaderiaIdLabel.Text = "Tipo Mercaderia:";
            // 
            // familiaMercaderiaIdLabel
            // 
            familiaMercaderiaIdLabel.AutoSize = true;
            familiaMercaderiaIdLabel.BackColor = System.Drawing.Color.Transparent;
            familiaMercaderiaIdLabel.Location = new System.Drawing.Point(197, 191);
            familiaMercaderiaIdLabel.Name = "familiaMercaderiaIdLabel";
            familiaMercaderiaIdLabel.Size = new System.Drawing.Size(131, 17);
            familiaMercaderiaIdLabel.TabIndex = 2;
            familiaMercaderiaIdLabel.Text = "Familia Mercaderia:";
            // 
            // BaseFormHeaderGroup
            // 
            this.BaseFormHeaderGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BaseFormHeaderGroup.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Calendar;
            this.BaseFormHeaderGroup.HeaderStyleSecondary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Form;
            this.BaseFormHeaderGroup.HeaderVisibleSecondary = false;
            this.BaseFormHeaderGroup.Location = new System.Drawing.Point(0, 31);
            this.BaseFormHeaderGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BaseFormHeaderGroup.Name = "BaseFormHeaderGroup";
            // 
            // BaseFormHeaderGroup.Panel
            // 
            this.BaseFormHeaderGroup.Panel.Controls.Add(this.kryptonPanel1);
            this.BaseFormHeaderGroup.Size = new System.Drawing.Size(923, 507);
            this.BaseFormHeaderGroup.StateNormal.HeaderPrimary.Border.Color1 = System.Drawing.SystemColors.ControlDarkDark;
            this.BaseFormHeaderGroup.StateNormal.HeaderPrimary.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.BaseFormHeaderGroup.StateNormal.HeaderPrimary.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.BaseFormHeaderGroup.StateNormal.HeaderPrimary.Border.Width = 1;
            this.BaseFormHeaderGroup.TabIndex = 13;
            this.BaseFormHeaderGroup.ValuesPrimary.Heading = "Mantenimiento Mercadería";
            this.BaseFormHeaderGroup.ValuesPrimary.Image = null;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(familiaMercaderiaIdLabel);
            this.kryptonPanel1.Controls.Add(this.familiaMercaderiaIdComboBox);
            this.kryptonPanel1.Controls.Add(codigoLabel);
            this.kryptonPanel1.Controls.Add(this.codigoTextBox);
            this.kryptonPanel1.Controls.Add(descripcionLabel);
            this.kryptonPanel1.Controls.Add(this.descripcionTextBox);
            this.kryptonPanel1.Controls.Add(nombreLabel);
            this.kryptonPanel1.Controls.Add(this.nombreTextBox);
            this.kryptonPanel1.Controls.Add(tipoMercaderiaIdLabel);
            this.kryptonPanel1.Controls.Add(this.tipoMercaderiaIdComboBox);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(921, 479);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // familiaMercaderiaIdComboBox
            // 
            this.familiaMercaderiaIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mercaderiaViewModelBindingSource, "FamiliaMercaderiaId", true));
            this.familiaMercaderiaIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.mercaderiaViewModelBindingSource, "FamiliaMercaderiaId", true));
            this.familiaMercaderiaIdComboBox.DataSource = this.familiaMercaderiaViewModelBindingSource;
            this.familiaMercaderiaIdComboBox.DisplayMember = "Nombre";
            this.familiaMercaderiaIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.familiaMercaderiaIdComboBox.FormattingEnabled = true;
            this.familiaMercaderiaIdComboBox.Location = new System.Drawing.Point(333, 188);
            this.familiaMercaderiaIdComboBox.Name = "familiaMercaderiaIdComboBox";
            this.familiaMercaderiaIdComboBox.Size = new System.Drawing.Size(337, 24);
            this.familiaMercaderiaIdComboBox.TabIndex = 3;
            this.familiaMercaderiaIdComboBox.ValueMember = "FamiliaMercaderiaId";
            // 
            // mercaderiaViewModelBindingSource
            // 
            this.mercaderiaViewModelBindingSource.DataSource = typeof(AdmCostoProduccion.Common.ViewModels.Inventario.MercaderiaViewModel);
            // 
            // familiaMercaderiaViewModelBindingSource
            // 
            this.familiaMercaderiaViewModelBindingSource.DataSource = typeof(AdmCostoProduccion.Common.ViewModels.Inventario.FamiliaMercaderiaViewModel);
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mercaderiaViewModelBindingSource, "Codigo", true));
            this.codigoTextBox.Location = new System.Drawing.Point(333, 217);
            this.codigoTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(337, 22);
            this.codigoTextBox.TabIndex = 5;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mercaderiaViewModelBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(333, 272);
            this.descripcionTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(337, 22);
            this.descripcionTextBox.TabIndex = 9;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mercaderiaViewModelBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(333, 244);
            this.nombreTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(337, 22);
            this.nombreTextBox.TabIndex = 7;
            // 
            // tipoMercaderiaIdComboBox
            // 
            this.tipoMercaderiaIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.mercaderiaViewModelBindingSource, "TipoMercaderiaId", true));
            this.tipoMercaderiaIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mercaderiaViewModelBindingSource, "TipoMercaderiaId", true));
            this.tipoMercaderiaIdComboBox.DataSource = this.tipoMercaderiaViewModelBindingSource;
            this.tipoMercaderiaIdComboBox.DisplayMember = "Nombre";
            this.tipoMercaderiaIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoMercaderiaIdComboBox.FormattingEnabled = true;
            this.tipoMercaderiaIdComboBox.Location = new System.Drawing.Point(333, 159);
            this.tipoMercaderiaIdComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tipoMercaderiaIdComboBox.Name = "tipoMercaderiaIdComboBox";
            this.tipoMercaderiaIdComboBox.Size = new System.Drawing.Size(337, 24);
            this.tipoMercaderiaIdComboBox.TabIndex = 1;
            this.tipoMercaderiaIdComboBox.ValueMember = "TipoMercaderiaId";
            // 
            // tipoMercaderiaViewModelBindingSource
            // 
            this.tipoMercaderiaViewModelBindingSource.DataSource = typeof(AdmCostoProduccion.Common.ViewModels.Inventario.TipoMercaderiaViewModel);
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
            this.BaseFormToolStrip.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BaseFormToolStrip.Size = new System.Drawing.Size(923, 31);
            this.BaseFormToolStrip.TabIndex = 12;
            this.BaseFormToolStrip.Text = "BaseFormToolStrip";
            // 
            // GrabarButton
            // 
            this.GrabarButton.Image = global::AdmCostoProduccion.Windows.Properties.Resources.save_16x16;
            this.GrabarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GrabarButton.Name = "GrabarButton";
            this.GrabarButton.Size = new System.Drawing.Size(78, 24);
            this.GrabarButton.Text = "Grabar";
            this.GrabarButton.Click += new System.EventHandler(this.GrabarButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.Image = global::AdmCostoProduccion.Windows.Properties.Resources.cancel_16x16;
            this.CancelarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(90, 24);
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // MntMercaderiaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 538);
            this.Controls.Add(this.BaseFormHeaderGroup);
            this.Controls.Add(this.BaseFormToolStrip);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MntMercaderiaForm";
            this.Text = "Mantenimiento Mercadería";
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup.Panel)).EndInit();
            this.BaseFormHeaderGroup.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup)).EndInit();
            this.BaseFormHeaderGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mercaderiaViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familiaMercaderiaViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoMercaderiaViewModelBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.BindingSource mercaderiaViewModelBindingSource;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.ComboBox tipoMercaderiaIdComboBox;
        private System.Windows.Forms.BindingSource tipoMercaderiaViewModelBindingSource;
        private System.Windows.Forms.ComboBox familiaMercaderiaIdComboBox;
        private System.Windows.Forms.BindingSource familiaMercaderiaViewModelBindingSource;
    }
}