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
            this.GridHeaderGroup = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.BuscarAgregarOrdenesButton = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.AgregarDetalleButton = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.ModificarDetalleButton = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.EliminarDetalleButton = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.DetalleDataGridView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.ordenProduccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoMercaderiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreMercaderiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procedimientoProduccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factorDistribucionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadMedidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoMpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoModDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoCifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.GridHeaderGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridHeaderGroup.Panel)).BeginInit();
            this.GridHeaderGroup.Panel.SuspendLayout();
            this.GridHeaderGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costoOrdenProduccionViewModelsBindingSource)).BeginInit();
            this.BaseFormToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.BackColor = System.Drawing.Color.Transparent;
            codigoLabel.Location = new System.Drawing.Point(18, 42);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(43, 13);
            codigoLabel.TabIndex = 12;
            codigoLabel.Text = "Codigo:";
            // 
            // configuracionValorizacionLabel
            // 
            configuracionValorizacionLabel.AutoSize = true;
            configuracionValorizacionLabel.BackColor = System.Drawing.Color.Transparent;
            configuracionValorizacionLabel.Location = new System.Drawing.Point(430, 16);
            configuracionValorizacionLabel.Name = "configuracionValorizacionLabel";
            configuracionValorizacionLabel.Size = new System.Drawing.Size(135, 13);
            configuracionValorizacionLabel.TabIndex = 14;
            configuracionValorizacionLabel.Text = "Configuracion Valorizacion:";
            // 
            // costoCifLabel
            // 
            costoCifLabel.AutoSize = true;
            costoCifLabel.BackColor = System.Drawing.Color.Transparent;
            costoCifLabel.Location = new System.Drawing.Point(430, 120);
            costoCifLabel.Name = "costoCifLabel";
            costoCifLabel.Size = new System.Drawing.Size(52, 13);
            costoCifLabel.TabIndex = 16;
            costoCifLabel.Text = "Costo Cif:";
            // 
            // costoModLabel
            // 
            costoModLabel.AutoSize = true;
            costoModLabel.BackColor = System.Drawing.Color.Transparent;
            costoModLabel.Location = new System.Drawing.Point(430, 95);
            costoModLabel.Name = "costoModLabel";
            costoModLabel.Size = new System.Drawing.Size(61, 13);
            costoModLabel.TabIndex = 18;
            costoModLabel.Text = "Costo Mod:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.BackColor = System.Drawing.Color.Transparent;
            descripcionLabel.Location = new System.Drawing.Point(18, 68);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 20;
            descripcionLabel.Text = "Descripcion:";
            // 
            // fechaFinLabel
            // 
            fechaFinLabel.AutoSize = true;
            fechaFinLabel.BackColor = System.Drawing.Color.Transparent;
            fechaFinLabel.Location = new System.Drawing.Point(18, 121);
            fechaFinLabel.Name = "fechaFinLabel";
            fechaFinLabel.Size = new System.Drawing.Size(57, 13);
            fechaFinLabel.TabIndex = 22;
            fechaFinLabel.Text = "Fecha Fin:";
            // 
            // fechaInicioLabel
            // 
            fechaInicioLabel.AutoSize = true;
            fechaInicioLabel.BackColor = System.Drawing.Color.Transparent;
            fechaInicioLabel.Location = new System.Drawing.Point(18, 95);
            fechaInicioLabel.Name = "fechaInicioLabel";
            fechaInicioLabel.Size = new System.Drawing.Size(68, 13);
            fechaInicioLabel.TabIndex = 24;
            fechaInicioLabel.Text = "Fecha Inicio:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.BackColor = System.Drawing.Color.Transparent;
            nombreLabel.Location = new System.Drawing.Point(430, 42);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 26;
            nombreLabel.Text = "Nombre:";
            // 
            // plantaFabricacionLabel
            // 
            plantaFabricacionLabel.AutoSize = true;
            plantaFabricacionLabel.BackColor = System.Drawing.Color.Transparent;
            plantaFabricacionLabel.Location = new System.Drawing.Point(18, 16);
            plantaFabricacionLabel.Name = "plantaFabricacionLabel";
            plantaFabricacionLabel.Size = new System.Drawing.Size(98, 13);
            plantaFabricacionLabel.TabIndex = 28;
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
            this.kryptonPanel1.Controls.Add(this.GridHeaderGroup);
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
            this.configuracionValorizacionComboBox.Location = new System.Drawing.Point(571, 13);
            this.configuracionValorizacionComboBox.Name = "configuracionValorizacionComboBox";
            this.configuracionValorizacionComboBox.Size = new System.Drawing.Size(252, 21);
            this.configuracionValorizacionComboBox.TabIndex = 15;
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
            this.codigoTextBox.Location = new System.Drawing.Point(148, 39);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(252, 20);
            this.codigoTextBox.TabIndex = 13;
            // 
            // costoCifTextBox
            // 
            this.costoCifTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.costoProduccionViewModelBindingSource, "CostoCif", true));
            this.costoCifTextBox.Location = new System.Drawing.Point(571, 117);
            this.costoCifTextBox.Name = "costoCifTextBox";
            this.costoCifTextBox.Size = new System.Drawing.Size(252, 20);
            this.costoCifTextBox.TabIndex = 17;
            // 
            // costoModTextBox
            // 
            this.costoModTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.costoProduccionViewModelBindingSource, "CostoMod", true));
            this.costoModTextBox.Location = new System.Drawing.Point(571, 92);
            this.costoModTextBox.Name = "costoModTextBox";
            this.costoModTextBox.Size = new System.Drawing.Size(252, 20);
            this.costoModTextBox.TabIndex = 19;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.costoProduccionViewModelBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(148, 65);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(252, 20);
            this.descripcionTextBox.TabIndex = 21;
            // 
            // fechaFinDateTimePicker
            // 
            this.fechaFinDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.costoProduccionViewModelBindingSource, "FechaFin", true));
            this.fechaFinDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaFinDateTimePicker.Location = new System.Drawing.Point(148, 117);
            this.fechaFinDateTimePicker.Name = "fechaFinDateTimePicker";
            this.fechaFinDateTimePicker.Size = new System.Drawing.Size(106, 20);
            this.fechaFinDateTimePicker.TabIndex = 23;
            // 
            // fechaInicioDateTimePicker
            // 
            this.fechaInicioDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.costoProduccionViewModelBindingSource, "FechaInicio", true));
            this.fechaInicioDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaInicioDateTimePicker.Location = new System.Drawing.Point(148, 92);
            this.fechaInicioDateTimePicker.Name = "fechaInicioDateTimePicker";
            this.fechaInicioDateTimePicker.Size = new System.Drawing.Size(106, 20);
            this.fechaInicioDateTimePicker.TabIndex = 25;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.costoProduccionViewModelBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(571, 39);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(252, 20);
            this.nombreTextBox.TabIndex = 27;
            // 
            // plantaFabricacionComboBox
            // 
            this.plantaFabricacionComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.costoProduccionViewModelBindingSource, "PlantaFabricacion", true));
            this.plantaFabricacionComboBox.DataSource = this.plantaFabricacionViewModelBindingSource;
            this.plantaFabricacionComboBox.DisplayMember = "Nombre";
            this.plantaFabricacionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.plantaFabricacionComboBox.FormattingEnabled = true;
            this.plantaFabricacionComboBox.Location = new System.Drawing.Point(148, 13);
            this.plantaFabricacionComboBox.Name = "plantaFabricacionComboBox";
            this.plantaFabricacionComboBox.Size = new System.Drawing.Size(252, 21);
            this.plantaFabricacionComboBox.TabIndex = 29;
            this.plantaFabricacionComboBox.ValueMember = "PlantaFabricacionId";
            // 
            // plantaFabricacionViewModelBindingSource
            // 
            this.plantaFabricacionViewModelBindingSource.DataSource = typeof(AdmCostoProduccion.Common.ViewModels.Maestro.PlantaFabricacionViewModel);
            // 
            // GridHeaderGroup
            // 
            this.GridHeaderGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridHeaderGroup.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup[] {
            this.BuscarAgregarOrdenesButton,
            this.AgregarDetalleButton,
            this.ModificarDetalleButton,
            this.EliminarDetalleButton});
            this.GridHeaderGroup.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.DockActive;
            this.GridHeaderGroup.HeaderVisibleSecondary = false;
            this.GridHeaderGroup.Location = new System.Drawing.Point(2, 142);
            this.GridHeaderGroup.Margin = new System.Windows.Forms.Padding(2);
            this.GridHeaderGroup.Name = "GridHeaderGroup";
            // 
            // GridHeaderGroup.Panel
            // 
            this.GridHeaderGroup.Panel.Controls.Add(this.DetalleDataGridView);
            this.GridHeaderGroup.Size = new System.Drawing.Size(829, 251);
            this.GridHeaderGroup.TabIndex = 12;
            this.GridHeaderGroup.ValuesPrimary.Heading = "Detalles";
            this.GridHeaderGroup.ValuesPrimary.Image = null;
            // 
            // BuscarAgregarOrdenesButton
            // 
            this.BuscarAgregarOrdenesButton.Checked = ComponentFactory.Krypton.Toolkit.ButtonCheckState.Unchecked;
            this.BuscarAgregarOrdenesButton.Image = global::AdmCostoProduccion.Windows.Properties.Resources.boorderitem_16x16;
            this.BuscarAgregarOrdenesButton.Text = "Buscar y Agregar Ordenes";
            this.BuscarAgregarOrdenesButton.UniqueName = "8E2FD0146A4347263DB2A5C7A6BAE528";
            this.BuscarAgregarOrdenesButton.Click += new System.EventHandler(this.BuscarAgregarOrdenesButton_Click);
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
            this.ordenProduccionDataGridViewTextBoxColumn,
            this.codigoMercaderiaDataGridViewTextBoxColumn,
            this.nombreMercaderiaDataGridViewTextBoxColumn,
            this.procedimientoProduccionDataGridViewTextBoxColumn,
            this.factorDistribucionDataGridViewTextBoxColumn,
            this.unidadMedidaDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.costoMpDataGridViewTextBoxColumn,
            this.costoModDataGridViewTextBoxColumn,
            this.costoCifDataGridViewTextBoxColumn});
            this.DetalleDataGridView.DataSource = this.costoOrdenProduccionViewModelsBindingSource;
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
            this.DetalleDataGridView.Size = new System.Drawing.Size(827, 222);
            this.DetalleDataGridView.TabIndex = 0;
            // 
            // ordenProduccionDataGridViewTextBoxColumn
            // 
            this.ordenProduccionDataGridViewTextBoxColumn.DataPropertyName = "OrdenProduccion";
            this.ordenProduccionDataGridViewTextBoxColumn.HeaderText = "OrdenProduccion";
            this.ordenProduccionDataGridViewTextBoxColumn.Name = "ordenProduccionDataGridViewTextBoxColumn";
            this.ordenProduccionDataGridViewTextBoxColumn.ReadOnly = true;
            this.ordenProduccionDataGridViewTextBoxColumn.Width = 130;
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
            // procedimientoProduccionDataGridViewTextBoxColumn
            // 
            this.procedimientoProduccionDataGridViewTextBoxColumn.DataPropertyName = "ProcedimientoProduccion";
            this.procedimientoProduccionDataGridViewTextBoxColumn.HeaderText = "ProcedimientoProduccion";
            this.procedimientoProduccionDataGridViewTextBoxColumn.Name = "procedimientoProduccionDataGridViewTextBoxColumn";
            this.procedimientoProduccionDataGridViewTextBoxColumn.ReadOnly = true;
            this.procedimientoProduccionDataGridViewTextBoxColumn.Width = 175;
            // 
            // factorDistribucionDataGridViewTextBoxColumn
            // 
            this.factorDistribucionDataGridViewTextBoxColumn.DataPropertyName = "FactorDistribucion";
            this.factorDistribucionDataGridViewTextBoxColumn.HeaderText = "FactorDistribucion";
            this.factorDistribucionDataGridViewTextBoxColumn.Name = "factorDistribucionDataGridViewTextBoxColumn";
            this.factorDistribucionDataGridViewTextBoxColumn.ReadOnly = true;
            this.factorDistribucionDataGridViewTextBoxColumn.Width = 133;
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
            // costoMpDataGridViewTextBoxColumn
            // 
            this.costoMpDataGridViewTextBoxColumn.DataPropertyName = "CostoMp";
            this.costoMpDataGridViewTextBoxColumn.HeaderText = "CostoMp";
            this.costoMpDataGridViewTextBoxColumn.Name = "costoMpDataGridViewTextBoxColumn";
            this.costoMpDataGridViewTextBoxColumn.ReadOnly = true;
            this.costoMpDataGridViewTextBoxColumn.Width = 85;
            // 
            // costoModDataGridViewTextBoxColumn
            // 
            this.costoModDataGridViewTextBoxColumn.DataPropertyName = "CostoMod";
            this.costoModDataGridViewTextBoxColumn.HeaderText = "CostoMod";
            this.costoModDataGridViewTextBoxColumn.Name = "costoModDataGridViewTextBoxColumn";
            this.costoModDataGridViewTextBoxColumn.ReadOnly = true;
            this.costoModDataGridViewTextBoxColumn.Width = 92;
            // 
            // costoCifDataGridViewTextBoxColumn
            // 
            this.costoCifDataGridViewTextBoxColumn.DataPropertyName = "CostoCif";
            this.costoCifDataGridViewTextBoxColumn.HeaderText = "CostoCif";
            this.costoCifDataGridViewTextBoxColumn.Name = "costoCifDataGridViewTextBoxColumn";
            this.costoCifDataGridViewTextBoxColumn.ReadOnly = true;
            this.costoCifDataGridViewTextBoxColumn.Width = 82;
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
            ((System.ComponentModel.ISupportInitialize)(this.GridHeaderGroup.Panel)).EndInit();
            this.GridHeaderGroup.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridHeaderGroup)).EndInit();
            this.GridHeaderGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).EndInit();
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
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup GridHeaderGroup;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup AgregarDetalleButton;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup ModificarDetalleButton;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup EliminarDetalleButton;
        private System.Windows.Forms.ComboBox configuracionValorizacionComboBox;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView DetalleDataGridView;
        protected System.Windows.Forms.ToolStrip BaseFormToolStrip;
        private System.Windows.Forms.ToolStripButton GrabarButton;
        private System.Windows.Forms.ToolStripButton CancelarButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordenProduccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoMercaderiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreMercaderiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn procedimientoProduccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn factorDistribucionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadMedidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoMpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoModDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoCifDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource costoOrdenProduccionViewModelsBindingSource;
        private System.Windows.Forms.BindingSource plantaFabricacionViewModelBindingSource;
        private System.Windows.Forms.BindingSource configuracionValorizacionViewModelBindingSource;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup BuscarAgregarOrdenesButton;
    }
}