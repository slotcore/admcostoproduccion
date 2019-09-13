namespace AdmCostoProduccion.Windows.Procesos.Inventario.InventarioInicial
{
    partial class MntInventarioInicialForm
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
            System.Windows.Forms.Label almacenLabel1;
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label descripcionLabel1;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label nombreLabel1;
            System.Windows.Forms.Label observacionLabel;
            this.BaseFormHeaderGroup = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.almacenComboBox = new System.Windows.Forms.ComboBox();
            this.inventarioInicialViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.almacenViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox1 = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nombreTextBox1 = new System.Windows.Forms.TextBox();
            this.observacionTextBox = new System.Windows.Forms.TextBox();
            this.GridHeaderGroup = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.AgregarDetalleButton = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.ModificarDetalleButton = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.EliminarDetalleButton = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.DetalleDataGridView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.codigoMercaderiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreMercaderiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadMedidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventarioInicialDetalleViewModelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BaseFormToolStrip = new System.Windows.Forms.ToolStrip();
            this.GrabarButton = new System.Windows.Forms.ToolStripButton();
            this.CancelarButton = new System.Windows.Forms.ToolStripButton();
            almacenLabel1 = new System.Windows.Forms.Label();
            codigoLabel = new System.Windows.Forms.Label();
            descripcionLabel1 = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            nombreLabel1 = new System.Windows.Forms.Label();
            observacionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup.Panel)).BeginInit();
            this.BaseFormHeaderGroup.Panel.SuspendLayout();
            this.BaseFormHeaderGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioInicialViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridHeaderGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridHeaderGroup.Panel)).BeginInit();
            this.GridHeaderGroup.Panel.SuspendLayout();
            this.GridHeaderGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioInicialDetalleViewModelsBindingSource)).BeginInit();
            this.BaseFormToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // almacenLabel1
            // 
            almacenLabel1.AutoSize = true;
            almacenLabel1.BackColor = System.Drawing.Color.Transparent;
            almacenLabel1.Location = new System.Drawing.Point(17, 19);
            almacenLabel1.Name = "almacenLabel1";
            almacenLabel1.Size = new System.Drawing.Size(51, 13);
            almacenLabel1.TabIndex = 0;
            almacenLabel1.Text = "Almacen:";
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.BackColor = System.Drawing.Color.Transparent;
            codigoLabel.Location = new System.Drawing.Point(429, 19);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(43, 13);
            codigoLabel.TabIndex = 2;
            codigoLabel.Text = "Codigo:";
            // 
            // descripcionLabel1
            // 
            descripcionLabel1.AutoSize = true;
            descripcionLabel1.BackColor = System.Drawing.Color.Transparent;
            descripcionLabel1.Location = new System.Drawing.Point(17, 71);
            descripcionLabel1.Name = "descripcionLabel1";
            descripcionLabel1.Size = new System.Drawing.Size(66, 13);
            descripcionLabel1.TabIndex = 8;
            descripcionLabel1.Text = "Descripcion:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.BackColor = System.Drawing.Color.Transparent;
            fechaLabel.Location = new System.Drawing.Point(17, 46);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 4;
            fechaLabel.Text = "Fecha:";
            // 
            // nombreLabel1
            // 
            nombreLabel1.AutoSize = true;
            nombreLabel1.BackColor = System.Drawing.Color.Transparent;
            nombreLabel1.Location = new System.Drawing.Point(429, 45);
            nombreLabel1.Name = "nombreLabel1";
            nombreLabel1.Size = new System.Drawing.Size(47, 13);
            nombreLabel1.TabIndex = 6;
            nombreLabel1.Text = "Nombre:";
            // 
            // observacionLabel
            // 
            observacionLabel.AutoSize = true;
            observacionLabel.BackColor = System.Drawing.Color.Transparent;
            observacionLabel.Location = new System.Drawing.Point(429, 71);
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
            this.BaseFormHeaderGroup.TabIndex = 27;
            this.BaseFormHeaderGroup.ValuesPrimary.Heading = "Mantenimiento Inventario Inicial";
            this.BaseFormHeaderGroup.ValuesPrimary.Image = null;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.AutoScroll = true;
            this.kryptonPanel1.Controls.Add(almacenLabel1);
            this.kryptonPanel1.Controls.Add(this.almacenComboBox);
            this.kryptonPanel1.Controls.Add(codigoLabel);
            this.kryptonPanel1.Controls.Add(this.codigoTextBox);
            this.kryptonPanel1.Controls.Add(descripcionLabel1);
            this.kryptonPanel1.Controls.Add(this.descripcionTextBox1);
            this.kryptonPanel1.Controls.Add(fechaLabel);
            this.kryptonPanel1.Controls.Add(this.fechaDateTimePicker);
            this.kryptonPanel1.Controls.Add(nombreLabel1);
            this.kryptonPanel1.Controls.Add(this.nombreTextBox1);
            this.kryptonPanel1.Controls.Add(observacionLabel);
            this.kryptonPanel1.Controls.Add(this.observacionTextBox);
            this.kryptonPanel1.Controls.Add(this.GridHeaderGroup);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(834, 395);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // almacenComboBox
            // 
            this.almacenComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioInicialViewModelBindingSource, "Almacen", true));
            this.almacenComboBox.DataSource = this.almacenViewModelBindingSource;
            this.almacenComboBox.DisplayMember = "Nombre";
            this.almacenComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.almacenComboBox.FormattingEnabled = true;
            this.almacenComboBox.Location = new System.Drawing.Point(127, 16);
            this.almacenComboBox.Name = "almacenComboBox";
            this.almacenComboBox.Size = new System.Drawing.Size(276, 21);
            this.almacenComboBox.TabIndex = 1;
            this.almacenComboBox.ValueMember = "AlmacenId";
            // 
            // inventarioInicialViewModelBindingSource
            // 
            this.inventarioInicialViewModelBindingSource.DataSource = typeof(AdmCostoProduccion.Common.ViewModels.Inventario.InventarioInicialViewModel);
            // 
            // almacenViewModelBindingSource
            // 
            this.almacenViewModelBindingSource.DataSource = typeof(AdmCostoProduccion.Common.ViewModels.Maestro.AlmacenViewModel);
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioInicialViewModelBindingSource, "Codigo", true));
            this.codigoTextBox.Location = new System.Drawing.Point(539, 16);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(277, 20);
            this.codigoTextBox.TabIndex = 3;
            // 
            // descripcionTextBox1
            // 
            this.descripcionTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioInicialViewModelBindingSource, "Descripcion", true));
            this.descripcionTextBox1.Location = new System.Drawing.Point(127, 68);
            this.descripcionTextBox1.Name = "descripcionTextBox1";
            this.descripcionTextBox1.Size = new System.Drawing.Size(276, 20);
            this.descripcionTextBox1.TabIndex = 9;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.inventarioInicialViewModelBindingSource, "Fecha", true));
            this.fechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(127, 42);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(106, 20);
            this.fechaDateTimePicker.TabIndex = 5;
            // 
            // nombreTextBox1
            // 
            this.nombreTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioInicialViewModelBindingSource, "Nombre", true));
            this.nombreTextBox1.Location = new System.Drawing.Point(539, 42);
            this.nombreTextBox1.Name = "nombreTextBox1";
            this.nombreTextBox1.Size = new System.Drawing.Size(277, 20);
            this.nombreTextBox1.TabIndex = 7;
            // 
            // observacionTextBox
            // 
            this.observacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioInicialViewModelBindingSource, "Observacion", true));
            this.observacionTextBox.Location = new System.Drawing.Point(539, 68);
            this.observacionTextBox.Name = "observacionTextBox";
            this.observacionTextBox.Size = new System.Drawing.Size(277, 20);
            this.observacionTextBox.TabIndex = 11;
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
            this.GridHeaderGroup.Location = new System.Drawing.Point(2, 102);
            this.GridHeaderGroup.Margin = new System.Windows.Forms.Padding(2);
            this.GridHeaderGroup.Name = "GridHeaderGroup";
            // 
            // GridHeaderGroup.Panel
            // 
            this.GridHeaderGroup.Panel.Controls.Add(this.DetalleDataGridView);
            this.GridHeaderGroup.Size = new System.Drawing.Size(829, 291);
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
            this.cantidadDataGridViewTextBoxColumn,
            this.costoDataGridViewTextBoxColumn});
            this.DetalleDataGridView.DataSource = this.inventarioInicialDetalleViewModelsBindingSource;
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
            this.DetalleDataGridView.Size = new System.Drawing.Size(827, 262);
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
            // costoDataGridViewTextBoxColumn
            // 
            this.costoDataGridViewTextBoxColumn.DataPropertyName = "Costo";
            this.costoDataGridViewTextBoxColumn.HeaderText = "Costo";
            this.costoDataGridViewTextBoxColumn.Name = "costoDataGridViewTextBoxColumn";
            this.costoDataGridViewTextBoxColumn.ReadOnly = true;
            this.costoDataGridViewTextBoxColumn.Width = 67;
            // 
            // inventarioInicialDetalleViewModelsBindingSource
            // 
            this.inventarioInicialDetalleViewModelsBindingSource.DataMember = "InventarioInicialDetalleViewModels";
            this.inventarioInicialDetalleViewModelsBindingSource.DataSource = this.inventarioInicialViewModelBindingSource;
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
            this.BaseFormToolStrip.TabIndex = 26;
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
            // MntInventarioInicialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 450);
            this.Controls.Add(this.BaseFormHeaderGroup);
            this.Controls.Add(this.BaseFormToolStrip);
            this.Name = "MntInventarioInicialForm";
            this.Text = "Mantenimiento Inventario Inicial";
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup.Panel)).EndInit();
            this.BaseFormHeaderGroup.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup)).EndInit();
            this.BaseFormHeaderGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioInicialViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridHeaderGroup.Panel)).EndInit();
            this.GridHeaderGroup.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridHeaderGroup)).EndInit();
            this.GridHeaderGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioInicialDetalleViewModelsBindingSource)).EndInit();
            this.BaseFormToolStrip.ResumeLayout(false);
            this.BaseFormToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup BaseFormHeaderGroup;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup GridHeaderGroup;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup AgregarDetalleButton;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup ModificarDetalleButton;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup EliminarDetalleButton;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView DetalleDataGridView;
        protected System.Windows.Forms.ToolStrip BaseFormToolStrip;
        private System.Windows.Forms.ToolStripButton GrabarButton;
        private System.Windows.Forms.ToolStripButton CancelarButton;
        private System.Windows.Forms.ComboBox almacenComboBox;
        private System.Windows.Forms.BindingSource inventarioInicialViewModelBindingSource;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox1;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.TextBox nombreTextBox1;
        private System.Windows.Forms.TextBox observacionTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoMercaderiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreMercaderiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadMedidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource inventarioInicialDetalleViewModelsBindingSource;
        private System.Windows.Forms.BindingSource almacenViewModelBindingSource;
    }
}