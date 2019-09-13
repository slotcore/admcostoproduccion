namespace AdmCostoProduccion.Windows.Procesos.Inventario.Recepcion
{
    partial class MntRecepcionForm
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label almacenIdLabel;
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label observacionLabel;
            System.Windows.Forms.Label fechaLabel;
            this.BaseFormHeaderGroup = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.recepcionViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.observacionTextBox = new System.Windows.Forms.TextBox();
            this.tipoDocumentoComboBox = new System.Windows.Forms.ComboBox();
            this.documentoRelacionadoTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.BuscarDocumentoButton = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.almacenIdComboBox = new System.Windows.Forms.ComboBox();
            this.almacenViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GridHeaderGroup = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.AgregarDetalleButton = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.ModificarDetalleButton = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.EliminarDetalleButton = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.DetalleDataGridView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.codigoMercaderiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreMercaderiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadMedidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recepcionDetalleViewModelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BaseFormToolStrip = new System.Windows.Forms.ToolStrip();
            this.GrabarButton = new System.Windows.Forms.ToolStripButton();
            this.CancelarButton = new System.Windows.Forms.ToolStripButton();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            almacenIdLabel = new System.Windows.Forms.Label();
            codigoLabel = new System.Windows.Forms.Label();
            observacionLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup.Panel)).BeginInit();
            this.BaseFormHeaderGroup.Panel.SuspendLayout();
            this.BaseFormHeaderGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recepcionViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridHeaderGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridHeaderGroup.Panel)).BeginInit();
            this.GridHeaderGroup.Panel.SuspendLayout();
            this.GridHeaderGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recepcionDetalleViewModelsBindingSource)).BeginInit();
            this.BaseFormToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Location = new System.Drawing.Point(16, 49);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(105, 13);
            label2.TabIndex = 4;
            label2.Text = "Número Documento:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Location = new System.Drawing.Point(428, 23);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(89, 13);
            label1.TabIndex = 2;
            label1.Text = "Tipo Documento:";
            // 
            // almacenIdLabel
            // 
            almacenIdLabel.AutoSize = true;
            almacenIdLabel.BackColor = System.Drawing.Color.Transparent;
            almacenIdLabel.Location = new System.Drawing.Point(16, 24);
            almacenIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            almacenIdLabel.Name = "almacenIdLabel";
            almacenIdLabel.Size = new System.Drawing.Size(51, 13);
            almacenIdLabel.TabIndex = 0;
            almacenIdLabel.Text = "Almacen:";
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.BackColor = System.Drawing.Color.Transparent;
            codigoLabel.Location = new System.Drawing.Point(428, 51);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(43, 13);
            codigoLabel.TabIndex = 6;
            codigoLabel.Text = "Codigo:";
            // 
            // observacionLabel
            // 
            observacionLabel.AutoSize = true;
            observacionLabel.BackColor = System.Drawing.Color.Transparent;
            observacionLabel.Location = new System.Drawing.Point(428, 77);
            observacionLabel.Name = "observacionLabel";
            observacionLabel.Size = new System.Drawing.Size(70, 13);
            observacionLabel.TabIndex = 10;
            observacionLabel.Text = "Observacion:";
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
            this.BaseFormHeaderGroup.TabIndex = 25;
            this.BaseFormHeaderGroup.ValuesPrimary.Heading = "Mantenimiento Recepción";
            this.BaseFormHeaderGroup.ValuesPrimary.Image = null;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.AutoScroll = true;
            this.kryptonPanel1.Controls.Add(fechaLabel);
            this.kryptonPanel1.Controls.Add(this.fechaDateTimePicker);
            this.kryptonPanel1.Controls.Add(codigoLabel);
            this.kryptonPanel1.Controls.Add(this.codigoTextBox);
            this.kryptonPanel1.Controls.Add(observacionLabel);
            this.kryptonPanel1.Controls.Add(this.observacionTextBox);
            this.kryptonPanel1.Controls.Add(label2);
            this.kryptonPanel1.Controls.Add(this.tipoDocumentoComboBox);
            this.kryptonPanel1.Controls.Add(this.documentoRelacionadoTextBox);
            this.kryptonPanel1.Controls.Add(label1);
            this.kryptonPanel1.Controls.Add(almacenIdLabel);
            this.kryptonPanel1.Controls.Add(this.almacenIdComboBox);
            this.kryptonPanel1.Controls.Add(this.GridHeaderGroup);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(834, 395);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recepcionViewModelBindingSource, "Codigo", true));
            this.codigoTextBox.Location = new System.Drawing.Point(538, 48);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(277, 20);
            this.codigoTextBox.TabIndex = 7;
            // 
            // recepcionViewModelBindingSource
            // 
            this.recepcionViewModelBindingSource.DataSource = typeof(AdmCostoProduccion.Common.ViewModels.Inventario.RecepcionViewModel);
            // 
            // observacionTextBox
            // 
            this.observacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recepcionViewModelBindingSource, "Observacion", true));
            this.observacionTextBox.Location = new System.Drawing.Point(538, 74);
            this.observacionTextBox.Name = "observacionTextBox";
            this.observacionTextBox.Size = new System.Drawing.Size(277, 20);
            this.observacionTextBox.TabIndex = 11;
            // 
            // tipoDocumentoComboBox
            // 
            this.tipoDocumentoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoDocumentoComboBox.FormattingEnabled = true;
            this.tipoDocumentoComboBox.Location = new System.Drawing.Point(538, 22);
            this.tipoDocumentoComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.tipoDocumentoComboBox.Name = "tipoDocumentoComboBox";
            this.tipoDocumentoComboBox.Size = new System.Drawing.Size(277, 21);
            this.tipoDocumentoComboBox.TabIndex = 3;
            // 
            // documentoRelacionadoTextBox
            // 
            this.documentoRelacionadoTextBox.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.BuscarDocumentoButton});
            this.documentoRelacionadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recepcionViewModelBindingSource, "NumeroDocumentoRelacionado", true));
            this.documentoRelacionadoTextBox.Location = new System.Drawing.Point(126, 45);
            this.documentoRelacionadoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.documentoRelacionadoTextBox.Name = "documentoRelacionadoTextBox";
            this.documentoRelacionadoTextBox.Size = new System.Drawing.Size(276, 24);
            this.documentoRelacionadoTextBox.TabIndex = 5;
            // 
            // BuscarDocumentoButton
            // 
            this.BuscarDocumentoButton.Image = global::AdmCostoProduccion.Windows.Properties.Resources.lookup_reference_16x16;
            this.BuscarDocumentoButton.UniqueName = "020B794215794657138ECD623B884FE9";
            this.BuscarDocumentoButton.Click += new System.EventHandler(this.BuscarDocumentoButton_Click);
            // 
            // almacenIdComboBox
            // 
            this.almacenIdComboBox.DataSource = this.almacenViewModelBindingSource;
            this.almacenIdComboBox.DisplayMember = "Nombre";
            this.almacenIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.almacenIdComboBox.FormattingEnabled = true;
            this.almacenIdComboBox.Location = new System.Drawing.Point(126, 22);
            this.almacenIdComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.almacenIdComboBox.Name = "almacenIdComboBox";
            this.almacenIdComboBox.Size = new System.Drawing.Size(277, 21);
            this.almacenIdComboBox.TabIndex = 1;
            this.almacenIdComboBox.ValueMember = "AlmacenId";
            // 
            // almacenViewModelBindingSource
            // 
            this.almacenViewModelBindingSource.DataSource = typeof(AdmCostoProduccion.Common.ViewModels.Maestro.AlmacenViewModel);
            // 
            // GridHeaderGroup
            // 
            this.GridHeaderGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridHeaderGroup.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup[] {
            this.AgregarDetalleButton,
            this.ModificarDetalleButton,
            this.EliminarDetalleButton});
            this.GridHeaderGroup.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.DockActive;
            this.GridHeaderGroup.HeaderVisibleSecondary = false;
            this.GridHeaderGroup.Location = new System.Drawing.Point(2, 106);
            this.GridHeaderGroup.Margin = new System.Windows.Forms.Padding(2);
            this.GridHeaderGroup.Name = "GridHeaderGroup";
            // 
            // GridHeaderGroup.Panel
            // 
            this.GridHeaderGroup.Panel.Controls.Add(this.DetalleDataGridView);
            this.GridHeaderGroup.Size = new System.Drawing.Size(829, 287);
            this.GridHeaderGroup.TabIndex = 12;
            this.GridHeaderGroup.ValuesPrimary.Heading = "Detalles";
            this.GridHeaderGroup.ValuesPrimary.Image = null;
            // 
            // AgregarDetalleButton
            // 
            this.AgregarDetalleButton.Image = global::AdmCostoProduccion.Windows.Properties.Resources.add_16x16;
            this.AgregarDetalleButton.Text = "Agregar";
            this.AgregarDetalleButton.UniqueName = "D267A9562B74495B63AE9A47F882F9F4";
            this.AgregarDetalleButton.Click += new System.EventHandler(this.AgregarDetalleButton_Click);
            // 
            // ModificarDetalleButton
            // 
            this.ModificarDetalleButton.Image = global::AdmCostoProduccion.Windows.Properties.Resources.edit_16x16;
            this.ModificarDetalleButton.Text = "Modificar";
            this.ModificarDetalleButton.UniqueName = "009B345D26464BC335B34D4F624BA8C4";
            this.ModificarDetalleButton.Click += new System.EventHandler(this.ModificarDetalleButton_Click);
            // 
            // EliminarDetalleButton
            // 
            this.EliminarDetalleButton.Image = global::AdmCostoProduccion.Windows.Properties.Resources.trash_16x16;
            this.EliminarDetalleButton.Text = "Eliminar";
            this.EliminarDetalleButton.UniqueName = "4177A44FBE3B48B414A2BA528F1EEA82";
            this.EliminarDetalleButton.Click += new System.EventHandler(this.EliminarDetalleButton_Click);
            // 
            // DetalleDataGridView
            // 
            this.DetalleDataGridView.AllowUserToAddRows = false;
            this.DetalleDataGridView.AllowUserToDeleteRows = false;
            this.DetalleDataGridView.AutoGenerateColumns = false;
            this.DetalleDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DetalleDataGridView.ColumnHeadersHeight = 25;
            this.DetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DetalleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoMercaderiaDataGridViewTextBoxColumn,
            this.nombreMercaderiaDataGridViewTextBoxColumn,
            this.unidadMedidaDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn});
            this.DetalleDataGridView.DataSource = this.recepcionDetalleViewModelsBindingSource;
            this.DetalleDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetalleDataGridView.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.DetalleDataGridView.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.DetalleDataGridView.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.DetalleDataGridView.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.DetalleDataGridView.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.DetalleDataGridView.Location = new System.Drawing.Point(0, 0);
            this.DetalleDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.DetalleDataGridView.Name = "DetalleDataGridView";
            this.DetalleDataGridView.ReadOnly = true;
            this.DetalleDataGridView.RowHeadersVisible = false;
            this.DetalleDataGridView.RowHeadersWidth = 51;
            this.DetalleDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DetalleDataGridView.Size = new System.Drawing.Size(827, 258);
            this.DetalleDataGridView.TabIndex = 0;
            // 
            // codigoMercaderiaDataGridViewTextBoxColumn
            // 
            this.codigoMercaderiaDataGridViewTextBoxColumn.DataPropertyName = "CodigoMercaderia";
            this.codigoMercaderiaDataGridViewTextBoxColumn.HeaderText = "CodigoMercaderia";
            this.codigoMercaderiaDataGridViewTextBoxColumn.Name = "codigoMercaderiaDataGridViewTextBoxColumn";
            this.codigoMercaderiaDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoMercaderiaDataGridViewTextBoxColumn.Width = 134;
            // 
            // nombreMercaderiaDataGridViewTextBoxColumn
            // 
            this.nombreMercaderiaDataGridViewTextBoxColumn.DataPropertyName = "NombreMercaderia";
            this.nombreMercaderiaDataGridViewTextBoxColumn.HeaderText = "NombreMercaderia";
            this.nombreMercaderiaDataGridViewTextBoxColumn.Name = "nombreMercaderiaDataGridViewTextBoxColumn";
            this.nombreMercaderiaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreMercaderiaDataGridViewTextBoxColumn.Width = 139;
            // 
            // unidadMedidaDataGridViewTextBoxColumn
            // 
            this.unidadMedidaDataGridViewTextBoxColumn.DataPropertyName = "UnidadMedida";
            this.unidadMedidaDataGridViewTextBoxColumn.HeaderText = "UnidadMedida";
            this.unidadMedidaDataGridViewTextBoxColumn.Name = "unidadMedidaDataGridViewTextBoxColumn";
            this.unidadMedidaDataGridViewTextBoxColumn.ReadOnly = true;
            this.unidadMedidaDataGridViewTextBoxColumn.Width = 114;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadDataGridViewTextBoxColumn.Width = 84;
            // 
            // recepcionDetalleViewModelsBindingSource
            // 
            this.recepcionDetalleViewModelsBindingSource.DataMember = "RecepcionDetalleViewModels";
            this.recepcionDetalleViewModelsBindingSource.DataSource = this.recepcionViewModelBindingSource;
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
            this.BaseFormToolStrip.TabIndex = 24;
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
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.BackColor = System.Drawing.Color.Transparent;
            fechaLabel.Location = new System.Drawing.Point(19, 77);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 8;
            fechaLabel.Text = "Fecha:";
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.recepcionViewModelBindingSource, "Fecha", true));
            this.fechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(126, 74);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(122, 20);
            this.fechaDateTimePicker.TabIndex = 9;
            // 
            // MntRecepcionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 450);
            this.Controls.Add(this.BaseFormHeaderGroup);
            this.Controls.Add(this.BaseFormToolStrip);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MntRecepcionForm";
            this.Text = "Mantenimiento Recepción";
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup.Panel)).EndInit();
            this.BaseFormHeaderGroup.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup)).EndInit();
            this.BaseFormHeaderGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recepcionViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridHeaderGroup.Panel)).EndInit();
            this.GridHeaderGroup.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridHeaderGroup)).EndInit();
            this.GridHeaderGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recepcionDetalleViewModelsBindingSource)).EndInit();
            this.BaseFormToolStrip.ResumeLayout(false);
            this.BaseFormToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup BaseFormHeaderGroup;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.ComboBox tipoDocumentoComboBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox documentoRelacionadoTextBox;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny BuscarDocumentoButton;
        private System.Windows.Forms.ComboBox almacenIdComboBox;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup GridHeaderGroup;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup AgregarDetalleButton;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup ModificarDetalleButton;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup EliminarDetalleButton;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView DetalleDataGridView;
        protected System.Windows.Forms.ToolStrip BaseFormToolStrip;
        private System.Windows.Forms.ToolStripButton GrabarButton;
        private System.Windows.Forms.ToolStripButton CancelarButton;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.BindingSource recepcionViewModelBindingSource;
        private System.Windows.Forms.TextBox observacionTextBox;
        private System.Windows.Forms.BindingSource almacenViewModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoMercaderiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreMercaderiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadMedidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource recepcionDetalleViewModelsBindingSource;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
    }
}