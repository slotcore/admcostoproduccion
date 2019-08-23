namespace AdmCostoProduccion.Windows.Mantenimiento.Inventario.ReglaAlmacenaje
{
    partial class MntReglaAlmacenajeForm
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
            System.Windows.Forms.Label almacenIdLabel;
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label familiaMercaderiaIdLabel;
            System.Windows.Forms.Label nombreLabel;
            this.BaseFormHeaderGroup = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.BaseFormToolStrip = new System.Windows.Forms.ToolStrip();
            this.GrabarButton = new System.Windows.Forms.ToolStripButton();
            this.CancelarButton = new System.Windows.Forms.ToolStripButton();
            this.reglaAlmacenajeViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.almacenIdComboBox = new System.Windows.Forms.ComboBox();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.familiaMercaderiaIdComboBox = new System.Windows.Forms.ComboBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.almacenViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.familiaMercaderiaViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            almacenIdLabel = new System.Windows.Forms.Label();
            codigoLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            familiaMercaderiaIdLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup.Panel)).BeginInit();
            this.BaseFormHeaderGroup.Panel.SuspendLayout();
            this.BaseFormHeaderGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.BaseFormToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reglaAlmacenajeViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familiaMercaderiaViewModelBindingSource)).BeginInit();
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
            this.BaseFormHeaderGroup.TabIndex = 29;
            this.BaseFormHeaderGroup.ValuesPrimary.Heading = "Mantenimiento Regla de Almacenaje";
            this.BaseFormHeaderGroup.ValuesPrimary.Image = null;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.AutoScroll = true;
            this.kryptonPanel1.Controls.Add(almacenIdLabel);
            this.kryptonPanel1.Controls.Add(this.almacenIdComboBox);
            this.kryptonPanel1.Controls.Add(codigoLabel);
            this.kryptonPanel1.Controls.Add(this.codigoTextBox);
            this.kryptonPanel1.Controls.Add(descripcionLabel);
            this.kryptonPanel1.Controls.Add(this.descripcionTextBox);
            this.kryptonPanel1.Controls.Add(familiaMercaderiaIdLabel);
            this.kryptonPanel1.Controls.Add(this.familiaMercaderiaIdComboBox);
            this.kryptonPanel1.Controls.Add(nombreLabel);
            this.kryptonPanel1.Controls.Add(this.nombreTextBox);
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
            this.BaseFormToolStrip.TabIndex = 28;
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
            // reglaAlmacenajeViewModelBindingSource
            // 
            this.reglaAlmacenajeViewModelBindingSource.DataSource = typeof(AdmCostoProduccion.Common.ViewModels.Inventario.ReglaAlmacenajeViewModel);
            // 
            // almacenIdLabel
            // 
            almacenIdLabel.AutoSize = true;
            almacenIdLabel.BackColor = System.Drawing.Color.Transparent;
            almacenIdLabel.Location = new System.Drawing.Point(151, 103);
            almacenIdLabel.Name = "almacenIdLabel";
            almacenIdLabel.Size = new System.Drawing.Size(51, 13);
            almacenIdLabel.TabIndex = 0;
            almacenIdLabel.Text = "Almacen:";
            // 
            // almacenIdComboBox
            // 
            this.almacenIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reglaAlmacenajeViewModelBindingSource, "AlmacenId", true));
            this.almacenIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.reglaAlmacenajeViewModelBindingSource, "AlmacenId", true));
            this.almacenIdComboBox.DataSource = this.almacenViewModelBindingSource;
            this.almacenIdComboBox.DisplayMember = "Nombre";
            this.almacenIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.almacenIdComboBox.FormattingEnabled = true;
            this.almacenIdComboBox.Location = new System.Drawing.Point(267, 100);
            this.almacenIdComboBox.Name = "almacenIdComboBox";
            this.almacenIdComboBox.Size = new System.Drawing.Size(346, 21);
            this.almacenIdComboBox.TabIndex = 1;
            this.almacenIdComboBox.ValueMember = "AlmacenId";
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.BackColor = System.Drawing.Color.Transparent;
            codigoLabel.Location = new System.Drawing.Point(151, 156);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(43, 13);
            codigoLabel.TabIndex = 4;
            codigoLabel.Text = "Codigo:";
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reglaAlmacenajeViewModelBindingSource, "Codigo", true));
            this.codigoTextBox.Location = new System.Drawing.Point(267, 153);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(346, 20);
            this.codigoTextBox.TabIndex = 5;
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.BackColor = System.Drawing.Color.Transparent;
            descripcionLabel.Location = new System.Drawing.Point(151, 208);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 8;
            descripcionLabel.Text = "Descripcion:";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reglaAlmacenajeViewModelBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(267, 205);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(346, 20);
            this.descripcionTextBox.TabIndex = 9;
            // 
            // familiaMercaderiaIdLabel
            // 
            familiaMercaderiaIdLabel.AutoSize = true;
            familiaMercaderiaIdLabel.BackColor = System.Drawing.Color.Transparent;
            familiaMercaderiaIdLabel.Location = new System.Drawing.Point(151, 129);
            familiaMercaderiaIdLabel.Name = "familiaMercaderiaIdLabel";
            familiaMercaderiaIdLabel.Size = new System.Drawing.Size(98, 13);
            familiaMercaderiaIdLabel.TabIndex = 2;
            familiaMercaderiaIdLabel.Text = "Familia Mercaderia:";
            // 
            // familiaMercaderiaIdComboBox
            // 
            this.familiaMercaderiaIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reglaAlmacenajeViewModelBindingSource, "FamiliaMercaderiaId", true));
            this.familiaMercaderiaIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.reglaAlmacenajeViewModelBindingSource, "FamiliaMercaderiaId", true));
            this.familiaMercaderiaIdComboBox.DataSource = this.familiaMercaderiaViewModelBindingSource;
            this.familiaMercaderiaIdComboBox.DisplayMember = "Nombre";
            this.familiaMercaderiaIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.familiaMercaderiaIdComboBox.FormattingEnabled = true;
            this.familiaMercaderiaIdComboBox.Location = new System.Drawing.Point(267, 126);
            this.familiaMercaderiaIdComboBox.Name = "familiaMercaderiaIdComboBox";
            this.familiaMercaderiaIdComboBox.Size = new System.Drawing.Size(346, 21);
            this.familiaMercaderiaIdComboBox.TabIndex = 3;
            this.familiaMercaderiaIdComboBox.ValueMember = "FamiliaMercaderiaId";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.BackColor = System.Drawing.Color.Transparent;
            nombreLabel.Location = new System.Drawing.Point(151, 182);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 6;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reglaAlmacenajeViewModelBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(267, 179);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(346, 20);
            this.nombreTextBox.TabIndex = 7;
            // 
            // almacenViewModelBindingSource
            // 
            this.almacenViewModelBindingSource.DataSource = typeof(AdmCostoProduccion.Common.ViewModels.Maestro.AlmacenViewModel);
            // 
            // familiaMercaderiaViewModelBindingSource
            // 
            this.familiaMercaderiaViewModelBindingSource.DataSource = typeof(AdmCostoProduccion.Common.ViewModels.Inventario.FamiliaMercaderiaViewModel);
            // 
            // MntReglaAlmacenajeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BaseFormHeaderGroup);
            this.Controls.Add(this.BaseFormToolStrip);
            this.Name = "MntReglaAlmacenajeForm";
            this.Text = "Mantenimiento Regla de Almacenaje";
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup.Panel)).EndInit();
            this.BaseFormHeaderGroup.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup)).EndInit();
            this.BaseFormHeaderGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.BaseFormToolStrip.ResumeLayout(false);
            this.BaseFormToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reglaAlmacenajeViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familiaMercaderiaViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup BaseFormHeaderGroup;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        protected System.Windows.Forms.ToolStrip BaseFormToolStrip;
        private System.Windows.Forms.ToolStripButton GrabarButton;
        private System.Windows.Forms.ToolStripButton CancelarButton;
        private System.Windows.Forms.ComboBox almacenIdComboBox;
        private System.Windows.Forms.BindingSource reglaAlmacenajeViewModelBindingSource;
        private System.Windows.Forms.BindingSource almacenViewModelBindingSource;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.ComboBox familiaMercaderiaIdComboBox;
        private System.Windows.Forms.BindingSource familiaMercaderiaViewModelBindingSource;
        private System.Windows.Forms.TextBox nombreTextBox;
    }
}