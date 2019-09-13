namespace AdmCostoProduccion.Windows.Procesos.Contabilidad.CostoProduccion
{
    partial class MntCostoProduccionForm
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
            System.Windows.Forms.Label configuracionValorizacionLabel;
            System.Windows.Forms.Label costoCifLabel;
            System.Windows.Forms.Label costoModLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label fechaFinLabel;
            System.Windows.Forms.Label fechaInicioLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label plantaFabricacionLabel;
            this.BaseFormHeaderGroup = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.configuracionValorizacionComboBox = new System.Windows.Forms.ComboBox();
            this.costoProduccionViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.configuracionValorizacionViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.costoCifTextBox = new System.Windows.Forms.TextBox();
            this.costoModTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.fechaFinDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fechaInicioDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.plantaFabricacionComboBox = new System.Windows.Forms.ComboBox();
            this.plantaFabricacionViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.costoOrdenProduccionViewModelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BaseFormToolStrip = new System.Windows.Forms.ToolStrip();
            this.GrabarButton = new System.Windows.Forms.ToolStripButton();
            this.CancelarButton = new System.Windows.Forms.ToolStripButton();
            codigoLabel = new System.Windows.Forms.Label();
            configuracionValorizacionLabel = new System.Windows.Forms.Label();
            costoCifLabel = new System.Windows.Forms.Label();
            costoModLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            fechaFinLabel = new System.Windows.Forms.Label();
            fechaInicioLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            plantaFabricacionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup.Panel)).BeginInit();
            this.BaseFormHeaderGroup.Panel.SuspendLayout();
            this.BaseFormHeaderGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.costoProduccionViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configuracionValorizacionViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantaFabricacionViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costoOrdenProduccionViewModelsBindingSource)).BeginInit();
            this.BaseFormToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.BackColor = System.Drawing.Color.Transparent;
            codigoLabel.Location = new System.Drawing.Point(15, 128);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(43, 13);
            codigoLabel.TabIndex = 4;
            codigoLabel.Text = "Codigo:";
            // 
            // configuracionValorizacionLabel
            // 
            configuracionValorizacionLabel.AutoSize = true;
            configuracionValorizacionLabel.BackColor = System.Drawing.Color.Transparent;
            configuracionValorizacionLabel.Location = new System.Drawing.Point(427, 102);
            configuracionValorizacionLabel.Name = "configuracionValorizacionLabel";
            configuracionValorizacionLabel.Size = new System.Drawing.Size(135, 13);
            configuracionValorizacionLabel.TabIndex = 2;
            configuracionValorizacionLabel.Text = "Configuracion Valorizacion:";
            // 
            // costoCifLabel
            // 
            costoCifLabel.AutoSize = true;
            costoCifLabel.BackColor = System.Drawing.Color.Transparent;
            costoCifLabel.Location = new System.Drawing.Point(427, 206);
            costoCifLabel.Name = "costoCifLabel";
            costoCifLabel.Size = new System.Drawing.Size(52, 13);
            costoCifLabel.TabIndex = 16;
            costoCifLabel.Text = "Costo Cif:";
            // 
            // costoModLabel
            // 
            costoModLabel.AutoSize = true;
            costoModLabel.BackColor = System.Drawing.Color.Transparent;
            costoModLabel.Location = new System.Drawing.Point(427, 181);
            costoModLabel.Name = "costoModLabel";
            costoModLabel.Size = new System.Drawing.Size(61, 13);
            costoModLabel.TabIndex = 14;
            costoModLabel.Text = "Costo Mod:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.BackColor = System.Drawing.Color.Transparent;
            descripcionLabel.Location = new System.Drawing.Point(15, 154);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 8;
            descripcionLabel.Text = "Descripcion:";
            // 
            // fechaFinLabel
            // 
            fechaFinLabel.AutoSize = true;
            fechaFinLabel.BackColor = System.Drawing.Color.Transparent;
            fechaFinLabel.Location = new System.Drawing.Point(15, 207);
            fechaFinLabel.Name = "fechaFinLabel";
            fechaFinLabel.Size = new System.Drawing.Size(57, 13);
            fechaFinLabel.TabIndex = 12;
            fechaFinLabel.Text = "Fecha Fin:";
            // 
            // fechaInicioLabel
            // 
            fechaInicioLabel.AutoSize = true;
            fechaInicioLabel.BackColor = System.Drawing.Color.Transparent;
            fechaInicioLabel.Location = new System.Drawing.Point(15, 181);
            fechaInicioLabel.Name = "fechaInicioLabel";
            fechaInicioLabel.Size = new System.Drawing.Size(68, 13);
            fechaInicioLabel.TabIndex = 10;
            fechaInicioLabel.Text = "Fecha Inicio:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.BackColor = System.Drawing.Color.Transparent;
            nombreLabel.Location = new System.Drawing.Point(427, 128);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 6;
            nombreLabel.Text = "Nombre:";
            // 
            // plantaFabricacionLabel
            // 
            plantaFabricacionLabel.AutoSize = true;
            plantaFabricacionLabel.BackColor = System.Drawing.Color.Transparent;
            plantaFabricacionLabel.Location = new System.Drawing.Point(15, 102);
            plantaFabricacionLabel.Name = "plantaFabricacionLabel";
            plantaFabricacionLabel.Size = new System.Drawing.Size(98, 13);
            plantaFabricacionLabel.TabIndex = 0;
            plantaFabricacionLabel.Text = "Planta Fabricacion:";
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
            this.BaseFormHeaderGroup.Size = new System.Drawing.Size(836, 419);
            this.BaseFormHeaderGroup.StateNormal.HeaderPrimary.Border.Color1 = System.Drawing.SystemColors.ControlDarkDark;
            this.BaseFormHeaderGroup.StateNormal.HeaderPrimary.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.BaseFormHeaderGroup.StateNormal.HeaderPrimary.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.BaseFormHeaderGroup.StateNormal.HeaderPrimary.Border.Width = 1;
            this.BaseFormHeaderGroup.TabIndex = 29;
            this.BaseFormHeaderGroup.ValuesPrimary.Heading = "Mantenimiento Costo de Producción";
            this.BaseFormHeaderGroup.ValuesPrimary.Image = null;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.AutoScroll = true;
            this.kryptonPanel1.Controls.Add(this.configuracionValorizacionComboBox);
            this.kryptonPanel1.Controls.Add(configuracionValorizacionLabel);
            this.kryptonPanel1.Controls.Add(codigoLabel);
            this.kryptonPanel1.Controls.Add(this.codigoTextBox);
            this.kryptonPanel1.Controls.Add(costoCifLabel);
            this.kryptonPanel1.Controls.Add(this.costoCifTextBox);
            this.kryptonPanel1.Controls.Add(costoModLabel);
            this.kryptonPanel1.Controls.Add(this.costoModTextBox);
            this.kryptonPanel1.Controls.Add(descripcionLabel);
            this.kryptonPanel1.Controls.Add(this.descripcionTextBox);
            this.kryptonPanel1.Controls.Add(fechaFinLabel);
            this.kryptonPanel1.Controls.Add(this.fechaFinDateTimePicker);
            this.kryptonPanel1.Controls.Add(fechaInicioLabel);
            this.kryptonPanel1.Controls.Add(this.fechaInicioDateTimePicker);
            this.kryptonPanel1.Controls.Add(nombreLabel);
            this.kryptonPanel1.Controls.Add(this.nombreTextBox);
            this.kryptonPanel1.Controls.Add(plantaFabricacionLabel);
            this.kryptonPanel1.Controls.Add(this.plantaFabricacionComboBox);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(834, 395);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // configuracionValorizacionComboBox
            // 
            this.configuracionValorizacionComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.costoProduccionViewModelBindingSource, "ConfiguracionValorizacion", true));
            this.configuracionValorizacionComboBox.DataSource = this.configuracionValorizacionViewModelBindingSource;
            this.configuracionValorizacionComboBox.DisplayMember = "Nombre";
            this.configuracionValorizacionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.configuracionValorizacionComboBox.FormattingEnabled = true;
            this.configuracionValorizacionComboBox.Location = new System.Drawing.Point(568, 99);
            this.configuracionValorizacionComboBox.Name = "configuracionValorizacionComboBox";
            this.configuracionValorizacionComboBox.Size = new System.Drawing.Size(252, 21);
            this.configuracionValorizacionComboBox.TabIndex = 3;
            this.configuracionValorizacionComboBox.ValueMember = "ConfiguracionValorizacionId";
            // 
            // costoProduccionViewModelBindingSource
            // 
            this.costoProduccionViewModelBindingSource.DataSource = typeof(AdmCostoProduccion.Common.ViewModels.Contabilidad.CostoProduccionViewModel);
            // 
            // configuracionValorizacionViewModelBindingSource
            // 
            this.configuracionValorizacionViewModelBindingSource.DataSource = typeof(AdmCostoProduccion.Common.ViewModels.Contabilidad.ConfiguracionValorizacionViewModel);
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.costoProduccionViewModelBindingSource, "Codigo", true));
            this.codigoTextBox.Location = new System.Drawing.Point(145, 125);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(252, 20);
            this.codigoTextBox.TabIndex = 5;
            // 
            // costoCifTextBox
            // 
            this.costoCifTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.costoProduccionViewModelBindingSource, "CostoCif", true));
            this.costoCifTextBox.Location = new System.Drawing.Point(568, 203);
            this.costoCifTextBox.Name = "costoCifTextBox";
            this.costoCifTextBox.Size = new System.Drawing.Size(252, 20);
            this.costoCifTextBox.TabIndex = 17;
            // 
            // costoModTextBox
            // 
            this.costoModTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.costoProduccionViewModelBindingSource, "CostoMod", true));
            this.costoModTextBox.Location = new System.Drawing.Point(568, 178);
            this.costoModTextBox.Name = "costoModTextBox";
            this.costoModTextBox.Size = new System.Drawing.Size(252, 20);
            this.costoModTextBox.TabIndex = 15;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.costoProduccionViewModelBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(145, 151);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(252, 20);
            this.descripcionTextBox.TabIndex = 9;
            // 
            // fechaFinDateTimePicker
            // 
            this.fechaFinDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.costoProduccionViewModelBindingSource, "FechaFin", true));
            this.fechaFinDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaFinDateTimePicker.Location = new System.Drawing.Point(145, 203);
            this.fechaFinDateTimePicker.Name = "fechaFinDateTimePicker";
            this.fechaFinDateTimePicker.Size = new System.Drawing.Size(106, 20);
            this.fechaFinDateTimePicker.TabIndex = 13;
            // 
            // fechaInicioDateTimePicker
            // 
            this.fechaInicioDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.costoProduccionViewModelBindingSource, "FechaInicio", true));
            this.fechaInicioDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaInicioDateTimePicker.Location = new System.Drawing.Point(145, 178);
            this.fechaInicioDateTimePicker.Name = "fechaInicioDateTimePicker";
            this.fechaInicioDateTimePicker.Size = new System.Drawing.Size(106, 20);
            this.fechaInicioDateTimePicker.TabIndex = 11;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.costoProduccionViewModelBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(568, 125);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(252, 20);
            this.nombreTextBox.TabIndex = 7;
            // 
            // plantaFabricacionComboBox
            // 
            this.plantaFabricacionComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.costoProduccionViewModelBindingSource, "PlantaFabricacion", true));
            this.plantaFabricacionComboBox.DataSource = this.plantaFabricacionViewModelBindingSource;
            this.plantaFabricacionComboBox.DisplayMember = "Nombre";
            this.plantaFabricacionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.plantaFabricacionComboBox.FormattingEnabled = true;
            this.plantaFabricacionComboBox.Location = new System.Drawing.Point(145, 99);
            this.plantaFabricacionComboBox.Name = "plantaFabricacionComboBox";
            this.plantaFabricacionComboBox.Size = new System.Drawing.Size(252, 21);
            this.plantaFabricacionComboBox.TabIndex = 1;
            this.plantaFabricacionComboBox.ValueMember = "PlantaFabricacionId";
            // 
            // plantaFabricacionViewModelBindingSource
            // 
            this.plantaFabricacionViewModelBindingSource.DataSource = typeof(AdmCostoProduccion.Common.ViewModels.Maestro.PlantaFabricacionViewModel);
            // 
            // costoOrdenProduccionViewModelsBindingSource
            // 
            this.costoOrdenProduccionViewModelsBindingSource.DataMember = "CostoOrdenProduccionViewModels";
            this.costoOrdenProduccionViewModelsBindingSource.DataSource = this.costoProduccionViewModelBindingSource;
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
            this.BaseFormToolStrip.Size = new System.Drawing.Size(836, 31);
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
            // MntCostoProduccionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 450);
            this.Controls.Add(this.BaseFormHeaderGroup);
            this.Controls.Add(this.BaseFormToolStrip);
            this.Name = "MntCostoProduccionForm";
            this.Text = "Mantenimiento Costo de Producción";
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup.Panel)).EndInit();
            this.BaseFormHeaderGroup.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup)).EndInit();
            this.BaseFormHeaderGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.costoProduccionViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configuracionValorizacionViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantaFabricacionViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costoOrdenProduccionViewModelsBindingSource)).EndInit();
            this.BaseFormToolStrip.ResumeLayout(false);
            this.BaseFormToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup BaseFormHeaderGroup;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.BindingSource costoProduccionViewModelBindingSource;
        private System.Windows.Forms.TextBox costoCifTextBox;
        private System.Windows.Forms.TextBox costoModTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.DateTimePicker fechaFinDateTimePicker;
        private System.Windows.Forms.DateTimePicker fechaInicioDateTimePicker;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.ComboBox plantaFabricacionComboBox;
        private System.Windows.Forms.ComboBox configuracionValorizacionComboBox;
        protected System.Windows.Forms.ToolStrip BaseFormToolStrip;
        private System.Windows.Forms.ToolStripButton GrabarButton;
        private System.Windows.Forms.ToolStripButton CancelarButton;
        private System.Windows.Forms.BindingSource costoOrdenProduccionViewModelsBindingSource;
        private System.Windows.Forms.BindingSource plantaFabricacionViewModelBindingSource;
        private System.Windows.Forms.BindingSource configuracionValorizacionViewModelBindingSource;
    }
}