namespace AdmCostoProduccion.Windows.Mantenimiento.Contabilidad.ConfiguracionValorizacion
{
    partial class MntConfiguracionValorizacionForm
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
            System.Windows.Forms.Label distribucionValorizacionLabel;
            System.Windows.Forms.Label metodoValorizacionLabel;
            System.Windows.Forms.Label nombreLabel;
            this.BaseFormHeaderGroup = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.BaseFormToolStrip = new System.Windows.Forms.ToolStrip();
            this.GrabarButton = new System.Windows.Forms.ToolStripButton();
            this.CancelarButton = new System.Windows.Forms.ToolStripButton();
            this.configuracionValorizacionViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.distribucionValorizacionComboBox = new System.Windows.Forms.ComboBox();
            this.metodoValorizacionComboBox = new System.Windows.Forms.ComboBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.distribucionValorizacionViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metodoValorizacionViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            codigoLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            distribucionValorizacionLabel = new System.Windows.Forms.Label();
            metodoValorizacionLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup.Panel)).BeginInit();
            this.BaseFormHeaderGroup.Panel.SuspendLayout();
            this.BaseFormHeaderGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.BaseFormToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configuracionValorizacionViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distribucionValorizacionViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodoValorizacionViewModelBindingSource)).BeginInit();
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
            this.BaseFormHeaderGroup.ValuesPrimary.Heading = "Mantenimiento Configuración de Valorización";
            this.BaseFormHeaderGroup.ValuesPrimary.Image = null;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.AutoScroll = true;
            this.kryptonPanel1.Controls.Add(codigoLabel);
            this.kryptonPanel1.Controls.Add(this.codigoTextBox);
            this.kryptonPanel1.Controls.Add(descripcionLabel);
            this.kryptonPanel1.Controls.Add(this.descripcionTextBox);
            this.kryptonPanel1.Controls.Add(distribucionValorizacionLabel);
            this.kryptonPanel1.Controls.Add(this.distribucionValorizacionComboBox);
            this.kryptonPanel1.Controls.Add(metodoValorizacionLabel);
            this.kryptonPanel1.Controls.Add(this.metodoValorizacionComboBox);
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
            // configuracionValorizacionViewModelBindingSource
            // 
            this.configuracionValorizacionViewModelBindingSource.DataSource = typeof(AdmCostoProduccion.Common.ViewModels.Contabilidad.ConfiguracionValorizacionViewModel);
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.BackColor = System.Drawing.Color.Transparent;
            codigoLabel.Location = new System.Drawing.Point(157, 176);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(43, 13);
            codigoLabel.TabIndex = 4;
            codigoLabel.Text = "Codigo:";
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configuracionValorizacionViewModelBindingSource, "Codigo", true));
            this.codigoTextBox.Location = new System.Drawing.Point(288, 173);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(347, 20);
            this.codigoTextBox.TabIndex = 5;
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.BackColor = System.Drawing.Color.Transparent;
            descripcionLabel.Location = new System.Drawing.Point(157, 228);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 8;
            descripcionLabel.Text = "Descripcion:";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configuracionValorizacionViewModelBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(288, 225);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(347, 20);
            this.descripcionTextBox.TabIndex = 9;
            // 
            // distribucionValorizacionLabel
            // 
            distribucionValorizacionLabel.AutoSize = true;
            distribucionValorizacionLabel.BackColor = System.Drawing.Color.Transparent;
            distribucionValorizacionLabel.Location = new System.Drawing.Point(157, 122);
            distribucionValorizacionLabel.Name = "distribucionValorizacionLabel";
            distribucionValorizacionLabel.Size = new System.Drawing.Size(125, 13);
            distribucionValorizacionLabel.TabIndex = 0;
            distribucionValorizacionLabel.Text = "Distribucion Valorizacion:";
            // 
            // distribucionValorizacionComboBox
            // 
            this.distribucionValorizacionComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configuracionValorizacionViewModelBindingSource, "DistribucionValorizacion", true));
            this.distribucionValorizacionComboBox.DataSource = this.distribucionValorizacionViewModelBindingSource;
            this.distribucionValorizacionComboBox.DisplayMember = "Nombre";
            this.distribucionValorizacionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.distribucionValorizacionComboBox.FormattingEnabled = true;
            this.distribucionValorizacionComboBox.Location = new System.Drawing.Point(288, 119);
            this.distribucionValorizacionComboBox.Name = "distribucionValorizacionComboBox";
            this.distribucionValorizacionComboBox.Size = new System.Drawing.Size(347, 21);
            this.distribucionValorizacionComboBox.TabIndex = 1;
            this.distribucionValorizacionComboBox.ValueMember = "DistribucionValorizacionId";
            // 
            // metodoValorizacionLabel
            // 
            metodoValorizacionLabel.AutoSize = true;
            metodoValorizacionLabel.BackColor = System.Drawing.Color.Transparent;
            metodoValorizacionLabel.Location = new System.Drawing.Point(157, 149);
            metodoValorizacionLabel.Name = "metodoValorizacionLabel";
            metodoValorizacionLabel.Size = new System.Drawing.Size(106, 13);
            metodoValorizacionLabel.TabIndex = 2;
            metodoValorizacionLabel.Text = "Metodo Valorizacion:";
            // 
            // metodoValorizacionComboBox
            // 
            this.metodoValorizacionComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configuracionValorizacionViewModelBindingSource, "MetodoValorizacion", true));
            this.metodoValorizacionComboBox.DataSource = this.metodoValorizacionViewModelBindingSource;
            this.metodoValorizacionComboBox.DisplayMember = "Nombre";
            this.metodoValorizacionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metodoValorizacionComboBox.FormattingEnabled = true;
            this.metodoValorizacionComboBox.Location = new System.Drawing.Point(288, 146);
            this.metodoValorizacionComboBox.Name = "metodoValorizacionComboBox";
            this.metodoValorizacionComboBox.Size = new System.Drawing.Size(347, 21);
            this.metodoValorizacionComboBox.TabIndex = 3;
            this.metodoValorizacionComboBox.ValueMember = "MetodoValorizacionId";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.BackColor = System.Drawing.Color.Transparent;
            nombreLabel.Location = new System.Drawing.Point(157, 202);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 6;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configuracionValorizacionViewModelBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(288, 199);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(347, 20);
            this.nombreTextBox.TabIndex = 7;
            // 
            // distribucionValorizacionViewModelBindingSource
            // 
            this.distribucionValorizacionViewModelBindingSource.DataSource = typeof(AdmCostoProduccion.Common.ViewModels.Contabilidad.DistribucionValorizacionViewModel);
            // 
            // metodoValorizacionViewModelBindingSource
            // 
            this.metodoValorizacionViewModelBindingSource.DataSource = typeof(AdmCostoProduccion.Common.ViewModels.Contabilidad.MetodoValorizacionViewModel);
            // 
            // MntConfiguracionValorizacionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BaseFormHeaderGroup);
            this.Controls.Add(this.BaseFormToolStrip);
            this.Name = "MntConfiguracionValorizacionForm";
            this.Text = "Mantenimiento Configuración de Valorización";
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup.Panel)).EndInit();
            this.BaseFormHeaderGroup.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup)).EndInit();
            this.BaseFormHeaderGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.BaseFormToolStrip.ResumeLayout(false);
            this.BaseFormToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configuracionValorizacionViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distribucionValorizacionViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodoValorizacionViewModelBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource configuracionValorizacionViewModelBindingSource;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.ComboBox distribucionValorizacionComboBox;
        private System.Windows.Forms.ComboBox metodoValorizacionComboBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.BindingSource distribucionValorizacionViewModelBindingSource;
        private System.Windows.Forms.BindingSource metodoValorizacionViewModelBindingSource;
    }
}