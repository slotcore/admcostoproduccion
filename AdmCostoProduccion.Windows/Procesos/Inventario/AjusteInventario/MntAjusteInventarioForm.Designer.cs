namespace AdmCostoProduccion.Windows.Procesos.Inventario.AjusteInventario
{
    partial class MntAjusteInventarioForm
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
            System.Windows.Forms.Label almacenLabel;
            System.Windows.Forms.Label codigoLabel1;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label fechaLabel1;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label observacionLabel1;
            System.Windows.Forms.Label tipoAjusteInventarioLabel;
            this.BaseFormHeaderGroup = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.almacenComboBox = new System.Windows.Forms.ComboBox();
            this.ajusteInventarioViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codigoTextBox1 = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.observacionTextBox1 = new System.Windows.Forms.TextBox();
            this.tipoAjusteInventarioComboBox = new System.Windows.Forms.ComboBox();
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
            this.ajusteInventarioDetalleViewModelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BaseFormToolStrip = new System.Windows.Forms.ToolStrip();
            this.GrabarButton = new System.Windows.Forms.ToolStripButton();
            this.CancelarButton = new System.Windows.Forms.ToolStripButton();
            this.almacenViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoAjusteInventarioViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            almacenLabel = new System.Windows.Forms.Label();
            codigoLabel1 = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            fechaLabel1 = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            observacionLabel1 = new System.Windows.Forms.Label();
            tipoAjusteInventarioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup.Panel)).BeginInit();
            this.BaseFormHeaderGroup.Panel.SuspendLayout();
            this.BaseFormHeaderGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ajusteInventarioViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridHeaderGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridHeaderGroup.Panel)).BeginInit();
            this.GridHeaderGroup.Panel.SuspendLayout();
            this.GridHeaderGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajusteInventarioDetalleViewModelsBindingSource)).BeginInit();
            this.BaseFormToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.almacenViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoAjusteInventarioViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // almacenLabel
            // 
            almacenLabel.AutoSize = true;
            almacenLabel.BackColor = System.Drawing.Color.Transparent;
            almacenLabel.Location = new System.Drawing.Point(15, 22);
            almacenLabel.Name = "almacenLabel";
            almacenLabel.Size = new System.Drawing.Size(51, 13);
            almacenLabel.TabIndex = 0;
            almacenLabel.Text = "Almacen:";
            // 
            // codigoLabel1
            // 
            codigoLabel1.AutoSize = true;
            codigoLabel1.BackColor = System.Drawing.Color.Transparent;
            codigoLabel1.Location = new System.Drawing.Point(15, 49);
            codigoLabel1.Name = "codigoLabel1";
            codigoLabel1.Size = new System.Drawing.Size(43, 13);
            codigoLabel1.TabIndex = 4;
            codigoLabel1.Text = "Codigo:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.BackColor = System.Drawing.Color.Transparent;
            descripcionLabel.Location = new System.Drawing.Point(427, 75);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 10;
            descripcionLabel.Text = "Descripcion:";
            // 
            // fechaLabel1
            // 
            fechaLabel1.AutoSize = true;
            fechaLabel1.BackColor = System.Drawing.Color.Transparent;
            fechaLabel1.Location = new System.Drawing.Point(427, 50);
            fechaLabel1.Name = "fechaLabel1";
            fechaLabel1.Size = new System.Drawing.Size(40, 13);
            fechaLabel1.TabIndex = 6;
            fechaLabel1.Text = "Fecha:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.BackColor = System.Drawing.Color.Transparent;
            nombreLabel.Location = new System.Drawing.Point(15, 75);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 8;
            nombreLabel.Text = "Nombre:";
            // 
            // observacionLabel1
            // 
            observacionLabel1.AutoSize = true;
            observacionLabel1.BackColor = System.Drawing.Color.Transparent;
            observacionLabel1.Location = new System.Drawing.Point(15, 101);
            observacionLabel1.Name = "observacionLabel1";
            observacionLabel1.Size = new System.Drawing.Size(70, 13);
            observacionLabel1.TabIndex = 12;
            observacionLabel1.Text = "Observacion:";
            // 
            // tipoAjusteInventarioLabel
            // 
            tipoAjusteInventarioLabel.AutoSize = true;
            tipoAjusteInventarioLabel.BackColor = System.Drawing.Color.Transparent;
            tipoAjusteInventarioLabel.Location = new System.Drawing.Point(427, 22);
            tipoAjusteInventarioLabel.Name = "tipoAjusteInventarioLabel";
            tipoAjusteInventarioLabel.Size = new System.Drawing.Size(84, 13);
            tipoAjusteInventarioLabel.TabIndex = 2;
            tipoAjusteInventarioLabel.Text = "Tipo Ajuste Inv.:";
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
            this.BaseFormHeaderGroup.ValuesPrimary.Heading = "Mantenimiento Ajuste de Inventario";
            this.BaseFormHeaderGroup.ValuesPrimary.Image = null;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.AutoScroll = true;
            this.kryptonPanel1.Controls.Add(almacenLabel);
            this.kryptonPanel1.Controls.Add(this.almacenComboBox);
            this.kryptonPanel1.Controls.Add(codigoLabel1);
            this.kryptonPanel1.Controls.Add(this.codigoTextBox1);
            this.kryptonPanel1.Controls.Add(descripcionLabel);
            this.kryptonPanel1.Controls.Add(this.descripcionTextBox);
            this.kryptonPanel1.Controls.Add(fechaLabel1);
            this.kryptonPanel1.Controls.Add(this.fechaDateTimePicker1);
            this.kryptonPanel1.Controls.Add(nombreLabel);
            this.kryptonPanel1.Controls.Add(this.nombreTextBox);
            this.kryptonPanel1.Controls.Add(observacionLabel1);
            this.kryptonPanel1.Controls.Add(this.observacionTextBox1);
            this.kryptonPanel1.Controls.Add(tipoAjusteInventarioLabel);
            this.kryptonPanel1.Controls.Add(this.tipoAjusteInventarioComboBox);
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
            this.almacenComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ajusteInventarioViewModelBindingSource, "Almacen", true));
            this.almacenComboBox.DataSource = this.almacenViewModelBindingSource;
            this.almacenComboBox.DisplayMember = "Nombre";
            this.almacenComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.almacenComboBox.FormattingEnabled = true;
            this.almacenComboBox.Location = new System.Drawing.Point(125, 19);
            this.almacenComboBox.Name = "almacenComboBox";
            this.almacenComboBox.Size = new System.Drawing.Size(276, 21);
            this.almacenComboBox.TabIndex = 1;
            this.almacenComboBox.ValueMember = "AlmacenId";
            // 
            // ajusteInventarioViewModelBindingSource
            // 
            this.ajusteInventarioViewModelBindingSource.DataSource = typeof(AdmCostoProduccion.Common.ViewModels.Inventario.AjusteInventarioViewModel);
            // 
            // codigoTextBox1
            // 
            this.codigoTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ajusteInventarioViewModelBindingSource, "Codigo", true));
            this.codigoTextBox1.Location = new System.Drawing.Point(125, 46);
            this.codigoTextBox1.Name = "codigoTextBox1";
            this.codigoTextBox1.Size = new System.Drawing.Size(276, 20);
            this.codigoTextBox1.TabIndex = 5;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ajusteInventarioViewModelBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(537, 72);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(277, 20);
            this.descripcionTextBox.TabIndex = 11;
            // 
            // fechaDateTimePicker1
            // 
            this.fechaDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ajusteInventarioViewModelBindingSource, "Fecha", true));
            this.fechaDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDateTimePicker1.Location = new System.Drawing.Point(537, 46);
            this.fechaDateTimePicker1.Name = "fechaDateTimePicker1";
            this.fechaDateTimePicker1.Size = new System.Drawing.Size(113, 20);
            this.fechaDateTimePicker1.TabIndex = 7;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ajusteInventarioViewModelBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(125, 72);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(276, 20);
            this.nombreTextBox.TabIndex = 9;
            // 
            // observacionTextBox1
            // 
            this.observacionTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ajusteInventarioViewModelBindingSource, "Observacion", true));
            this.observacionTextBox1.Location = new System.Drawing.Point(125, 98);
            this.observacionTextBox1.Name = "observacionTextBox1";
            this.observacionTextBox1.Size = new System.Drawing.Size(276, 20);
            this.observacionTextBox1.TabIndex = 13;
            // 
            // tipoAjusteInventarioComboBox
            // 
            this.tipoAjusteInventarioComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ajusteInventarioViewModelBindingSource, "TipoAjusteInventario", true));
            this.tipoAjusteInventarioComboBox.DataSource = this.tipoAjusteInventarioViewModelBindingSource;
            this.tipoAjusteInventarioComboBox.DisplayMember = "Nombre";
            this.tipoAjusteInventarioComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoAjusteInventarioComboBox.FormattingEnabled = true;
            this.tipoAjusteInventarioComboBox.Location = new System.Drawing.Point(537, 19);
            this.tipoAjusteInventarioComboBox.Name = "tipoAjusteInventarioComboBox";
            this.tipoAjusteInventarioComboBox.Size = new System.Drawing.Size(277, 21);
            this.tipoAjusteInventarioComboBox.TabIndex = 3;
            this.tipoAjusteInventarioComboBox.ValueMember = "TipoAjusteInventarioId";
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
            this.GridHeaderGroup.Location = new System.Drawing.Point(2, 123);
            this.GridHeaderGroup.Margin = new System.Windows.Forms.Padding(2);
            this.GridHeaderGroup.Name = "GridHeaderGroup";
            // 
            // GridHeaderGroup.Panel
            // 
            this.GridHeaderGroup.Panel.Controls.Add(this.DetalleDataGridView);
            this.GridHeaderGroup.Size = new System.Drawing.Size(829, 270);
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
            this.DetalleDataGridView.DataSource = this.ajusteInventarioDetalleViewModelsBindingSource;
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
            this.DetalleDataGridView.Size = new System.Drawing.Size(827, 241);
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
            // ajusteInventarioDetalleViewModelsBindingSource
            // 
            this.ajusteInventarioDetalleViewModelsBindingSource.DataMember = "AjusteInventarioDetalleViewModels";
            this.ajusteInventarioDetalleViewModelsBindingSource.DataSource = this.ajusteInventarioViewModelBindingSource;
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
            // almacenViewModelBindingSource
            // 
            this.almacenViewModelBindingSource.DataSource = typeof(AdmCostoProduccion.Common.ViewModels.Maestro.AlmacenViewModel);
            // 
            // tipoAjusteInventarioViewModelBindingSource
            // 
            this.tipoAjusteInventarioViewModelBindingSource.DataSource = typeof(AdmCostoProduccion.Common.ViewModels.Inventario.TipoAjusteInventarioViewModel);
            // 
            // MntAjusteInventarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 450);
            this.Controls.Add(this.BaseFormHeaderGroup);
            this.Controls.Add(this.BaseFormToolStrip);
            this.Name = "MntAjusteInventarioForm";
            this.Text = "Mantenimiento Ajuste de Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup.Panel)).EndInit();
            this.BaseFormHeaderGroup.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup)).EndInit();
            this.BaseFormHeaderGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ajusteInventarioViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridHeaderGroup.Panel)).EndInit();
            this.GridHeaderGroup.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridHeaderGroup)).EndInit();
            this.GridHeaderGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajusteInventarioDetalleViewModelsBindingSource)).EndInit();
            this.BaseFormToolStrip.ResumeLayout(false);
            this.BaseFormToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.almacenViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoAjusteInventarioViewModelBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource ajusteInventarioViewModelBindingSource;
        private System.Windows.Forms.TextBox codigoTextBox1;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker1;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox observacionTextBox1;
        private System.Windows.Forms.ComboBox tipoAjusteInventarioComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoMercaderiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreMercaderiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadMedidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ajusteInventarioDetalleViewModelsBindingSource;
        private System.Windows.Forms.BindingSource almacenViewModelBindingSource;
        private System.Windows.Forms.BindingSource tipoAjusteInventarioViewModelBindingSource;
    }
}