namespace AdmCostoProduccion.Windows.Mantenimiento.Produccion.ProcedimientoProduccion
{
    partial class MntProcedimientoProduccionForm
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
            System.Windows.Forms.Label cantidadLabel;
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label mercaderiaIdLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label unidadMedidaIdLabel;
            this.BaseFormHeaderGroup = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.mercaderiaTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.BuscarMercaderiaButton = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.procedimientoProduccionViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GridHeaderGroup = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.AgregarDetalleButton = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.ModificarDetalleButton = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.EliminarDetalleButton = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.DetalleDataGridView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.codigoMercaderiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreMercaderiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadMedidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procedimientoProduccionInsumoViewModelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cantidadTextBox = new System.Windows.Forms.TextBox();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.unidadMedidaIdComboBox = new System.Windows.Forms.ComboBox();
            this.unidadMedidaViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BaseFormToolStrip = new System.Windows.Forms.ToolStrip();
            this.GrabarButton = new System.Windows.Forms.ToolStripButton();
            this.CancelarButton = new System.Windows.Forms.ToolStripButton();
            cantidadLabel = new System.Windows.Forms.Label();
            codigoLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            mercaderiaIdLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            unidadMedidaIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup.Panel)).BeginInit();
            this.BaseFormHeaderGroup.Panel.SuspendLayout();
            this.BaseFormHeaderGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.procedimientoProduccionViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridHeaderGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridHeaderGroup.Panel)).BeginInit();
            this.GridHeaderGroup.Panel.SuspendLayout();
            this.GridHeaderGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procedimientoProduccionInsumoViewModelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadMedidaViewModelBindingSource)).BeginInit();
            this.BaseFormToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.BackColor = System.Drawing.Color.Transparent;
            cantidadLabel.Location = new System.Drawing.Point(39, 191);
            cantidadLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(68, 17);
            cantidadLabel.TabIndex = 10;
            cantidadLabel.Text = "Cantidad:";
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.BackColor = System.Drawing.Color.Transparent;
            codigoLabel.Location = new System.Drawing.Point(39, 95);
            codigoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(56, 17);
            codigoLabel.TabIndex = 4;
            codigoLabel.Text = "Codigo:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.BackColor = System.Drawing.Color.Transparent;
            descripcionLabel.Location = new System.Drawing.Point(39, 159);
            descripcionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(86, 17);
            descripcionLabel.TabIndex = 8;
            descripcionLabel.Text = "Descripcion:";
            // 
            // mercaderiaIdLabel
            // 
            mercaderiaIdLabel.AutoSize = true;
            mercaderiaIdLabel.BackColor = System.Drawing.Color.Transparent;
            mercaderiaIdLabel.Location = new System.Drawing.Point(39, 28);
            mercaderiaIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mercaderiaIdLabel.Name = "mercaderiaIdLabel";
            mercaderiaIdLabel.Size = new System.Drawing.Size(83, 17);
            mercaderiaIdLabel.TabIndex = 0;
            mercaderiaIdLabel.Text = "Mercaderia:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.BackColor = System.Drawing.Color.Transparent;
            nombreLabel.Location = new System.Drawing.Point(39, 127);
            nombreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(62, 17);
            nombreLabel.TabIndex = 6;
            nombreLabel.Text = "Nombre:";
            // 
            // unidadMedidaIdLabel
            // 
            unidadMedidaIdLabel.AutoSize = true;
            unidadMedidaIdLabel.BackColor = System.Drawing.Color.Transparent;
            unidadMedidaIdLabel.Location = new System.Drawing.Point(39, 62);
            unidadMedidaIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            unidadMedidaIdLabel.Name = "unidadMedidaIdLabel";
            unidadMedidaIdLabel.Size = new System.Drawing.Size(107, 17);
            unidadMedidaIdLabel.TabIndex = 2;
            unidadMedidaIdLabel.Text = "Unidad Medida:";
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
            this.BaseFormHeaderGroup.Size = new System.Drawing.Size(1067, 523);
            this.BaseFormHeaderGroup.StateNormal.HeaderPrimary.Border.Color1 = System.Drawing.SystemColors.ControlDarkDark;
            this.BaseFormHeaderGroup.StateNormal.HeaderPrimary.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.BaseFormHeaderGroup.StateNormal.HeaderPrimary.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.BaseFormHeaderGroup.StateNormal.HeaderPrimary.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.BaseFormHeaderGroup.StateNormal.HeaderPrimary.Border.Width = 1;
            this.BaseFormHeaderGroup.TabIndex = 21;
            this.BaseFormHeaderGroup.ValuesPrimary.Heading = "Mantenimiento Procedimiento de Producción";
            this.BaseFormHeaderGroup.ValuesPrimary.Image = null;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.mercaderiaTextBox);
            this.kryptonPanel1.Controls.Add(this.GridHeaderGroup);
            this.kryptonPanel1.Controls.Add(cantidadLabel);
            this.kryptonPanel1.Controls.Add(this.cantidadTextBox);
            this.kryptonPanel1.Controls.Add(codigoLabel);
            this.kryptonPanel1.Controls.Add(this.codigoTextBox);
            this.kryptonPanel1.Controls.Add(descripcionLabel);
            this.kryptonPanel1.Controls.Add(this.descripcionTextBox);
            this.kryptonPanel1.Controls.Add(mercaderiaIdLabel);
            this.kryptonPanel1.Controls.Add(nombreLabel);
            this.kryptonPanel1.Controls.Add(this.nombreTextBox);
            this.kryptonPanel1.Controls.Add(unidadMedidaIdLabel);
            this.kryptonPanel1.Controls.Add(this.unidadMedidaIdComboBox);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1065, 495);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // mercaderiaTextBox
            // 
            this.mercaderiaTextBox.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.BuscarMercaderiaButton});
            this.mercaderiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.procedimientoProduccionViewModelBindingSource, "NombreMercaderia", true));
            this.mercaderiaTextBox.Location = new System.Drawing.Point(172, 25);
            this.mercaderiaTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mercaderiaTextBox.Name = "mercaderiaTextBox";
            this.mercaderiaTextBox.Size = new System.Drawing.Size(487, 27);
            this.mercaderiaTextBox.TabIndex = 1;
            // 
            // BuscarMercaderiaButton
            // 
            this.BuscarMercaderiaButton.Image = global::AdmCostoProduccion.Windows.Properties.Resources.lookup_reference_16x16;
            this.BuscarMercaderiaButton.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Inherit;
            this.BuscarMercaderiaButton.ToolTipStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ToolTip;
            this.BuscarMercaderiaButton.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Generic;
            this.BuscarMercaderiaButton.UniqueName = "020B794215794657138ECD623B884FE9";
            this.BuscarMercaderiaButton.Click += new System.EventHandler(this.BuscarMercaderiaButton_Click);
            // 
            // procedimientoProduccionViewModelBindingSource
            // 
            this.procedimientoProduccionViewModelBindingSource.DataSource = typeof(AdmCostoProduccion.Common.ViewModels.Produccion.ProcedimientoProduccionViewModel);
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
            this.GridHeaderGroup.Location = new System.Drawing.Point(3, 235);
            this.GridHeaderGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GridHeaderGroup.Name = "GridHeaderGroup";
            // 
            // GridHeaderGroup.Panel
            // 
            this.GridHeaderGroup.Panel.Controls.Add(this.DetalleDataGridView);
            this.GridHeaderGroup.Size = new System.Drawing.Size(1060, 259);
            this.GridHeaderGroup.TabIndex = 12;
            this.GridHeaderGroup.ValuesPrimary.Heading = "Detalles";
            this.GridHeaderGroup.ValuesPrimary.Image = null;
            // 
            // AgregarDetalleButton
            // 
            this.AgregarDetalleButton.Image = global::AdmCostoProduccion.Windows.Properties.Resources.add_16x16;
            this.AgregarDetalleButton.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Inherit;
            this.AgregarDetalleButton.Text = "Agregar";
            this.AgregarDetalleButton.ToolTipStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ToolTip;
            this.AgregarDetalleButton.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Generic;
            this.AgregarDetalleButton.UniqueName = "D267A9562B74495B63AE9A47F882F9F4";
            this.AgregarDetalleButton.Click += new System.EventHandler(this.AgregarInsumoButton_Click);
            // 
            // ModificarDetalleButton
            // 
            this.ModificarDetalleButton.Image = global::AdmCostoProduccion.Windows.Properties.Resources.edit_16x16;
            this.ModificarDetalleButton.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Inherit;
            this.ModificarDetalleButton.Text = "Modificar";
            this.ModificarDetalleButton.ToolTipStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ToolTip;
            this.ModificarDetalleButton.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Generic;
            this.ModificarDetalleButton.UniqueName = "009B345D26464BC335B34D4F624BA8C4";
            this.ModificarDetalleButton.Click += new System.EventHandler(this.ModificarInsumoButton_Click);
            // 
            // EliminarDetalleButton
            // 
            this.EliminarDetalleButton.Image = global::AdmCostoProduccion.Windows.Properties.Resources.trash_16x16;
            this.EliminarDetalleButton.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Inherit;
            this.EliminarDetalleButton.Text = "Eliminar";
            this.EliminarDetalleButton.ToolTipStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ToolTip;
            this.EliminarDetalleButton.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Generic;
            this.EliminarDetalleButton.UniqueName = "4177A44FBE3B48B414A2BA528F1EEA82";
            this.EliminarDetalleButton.Click += new System.EventHandler(this.EliminarInsumoButton_Click);
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
            this.DetalleDataGridView.DataSource = this.procedimientoProduccionInsumoViewModelsBindingSource;
            this.DetalleDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetalleDataGridView.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.DetalleDataGridView.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.DetalleDataGridView.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.DetalleDataGridView.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.DetalleDataGridView.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.DetalleDataGridView.Location = new System.Drawing.Point(0, 0);
            this.DetalleDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DetalleDataGridView.Name = "DetalleDataGridView";
            this.DetalleDataGridView.ReadOnly = true;
            this.DetalleDataGridView.RowHeadersVisible = false;
            this.DetalleDataGridView.RowHeadersWidth = 51;
            this.DetalleDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DetalleDataGridView.Size = new System.Drawing.Size(1058, 226);
            this.DetalleDataGridView.TabIndex = 0;
            // 
            // codigoMercaderiaDataGridViewTextBoxColumn
            // 
            this.codigoMercaderiaDataGridViewTextBoxColumn.DataPropertyName = "CodigoMercaderia";
            this.codigoMercaderiaDataGridViewTextBoxColumn.HeaderText = "CodigoMercaderia";
            this.codigoMercaderiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codigoMercaderiaDataGridViewTextBoxColumn.Name = "codigoMercaderiaDataGridViewTextBoxColumn";
            this.codigoMercaderiaDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoMercaderiaDataGridViewTextBoxColumn.Width = 166;
            // 
            // nombreMercaderiaDataGridViewTextBoxColumn
            // 
            this.nombreMercaderiaDataGridViewTextBoxColumn.DataPropertyName = "NombreMercaderia";
            this.nombreMercaderiaDataGridViewTextBoxColumn.HeaderText = "NombreMercaderia";
            this.nombreMercaderiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreMercaderiaDataGridViewTextBoxColumn.Name = "nombreMercaderiaDataGridViewTextBoxColumn";
            this.nombreMercaderiaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreMercaderiaDataGridViewTextBoxColumn.Width = 172;
            // 
            // unidadMedidaDataGridViewTextBoxColumn
            // 
            this.unidadMedidaDataGridViewTextBoxColumn.DataPropertyName = "UnidadMedida";
            this.unidadMedidaDataGridViewTextBoxColumn.HeaderText = "UnidadMedida";
            this.unidadMedidaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unidadMedidaDataGridViewTextBoxColumn.Name = "unidadMedidaDataGridViewTextBoxColumn";
            this.unidadMedidaDataGridViewTextBoxColumn.ReadOnly = true;
            this.unidadMedidaDataGridViewTextBoxColumn.Width = 141;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadDataGridViewTextBoxColumn.Width = 102;
            // 
            // procedimientoProduccionInsumoViewModelsBindingSource
            // 
            this.procedimientoProduccionInsumoViewModelsBindingSource.DataMember = "ProcedimientoProduccionInsumoViewModels";
            this.procedimientoProduccionInsumoViewModelsBindingSource.DataSource = this.procedimientoProduccionViewModelBindingSource;
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.procedimientoProduccionViewModelBindingSource, "Cantidad", true));
            this.cantidadTextBox.Location = new System.Drawing.Point(172, 187);
            this.cantidadTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(487, 22);
            this.cantidadTextBox.TabIndex = 11;
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.procedimientoProduccionViewModelBindingSource, "Codigo", true));
            this.codigoTextBox.Location = new System.Drawing.Point(172, 91);
            this.codigoTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(487, 22);
            this.codigoTextBox.TabIndex = 5;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.procedimientoProduccionViewModelBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(172, 155);
            this.descripcionTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(487, 22);
            this.descripcionTextBox.TabIndex = 9;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.procedimientoProduccionViewModelBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(172, 123);
            this.nombreTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(487, 22);
            this.nombreTextBox.TabIndex = 7;
            // 
            // unidadMedidaIdComboBox
            // 
            this.unidadMedidaIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.procedimientoProduccionViewModelBindingSource, "UnidadMedidaId", true));
            this.unidadMedidaIdComboBox.DataSource = this.unidadMedidaViewModelBindingSource;
            this.unidadMedidaIdComboBox.DisplayMember = "Nombre";
            this.unidadMedidaIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unidadMedidaIdComboBox.FormattingEnabled = true;
            this.unidadMedidaIdComboBox.Location = new System.Drawing.Point(172, 58);
            this.unidadMedidaIdComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.unidadMedidaIdComboBox.Name = "unidadMedidaIdComboBox";
            this.unidadMedidaIdComboBox.Size = new System.Drawing.Size(487, 24);
            this.unidadMedidaIdComboBox.TabIndex = 3;
            this.unidadMedidaIdComboBox.ValueMember = "UnidadMedidaId";
            // 
            // unidadMedidaViewModelBindingSource
            // 
            this.unidadMedidaViewModelBindingSource.DataSource = typeof(AdmCostoProduccion.Common.ViewModels.Inventario.UnidadMedidaViewModel);
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
            this.BaseFormToolStrip.Size = new System.Drawing.Size(1067, 31);
            this.BaseFormToolStrip.TabIndex = 20;
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
            // MntProcedimientoProduccionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.BaseFormHeaderGroup);
            this.Controls.Add(this.BaseFormToolStrip);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MntProcedimientoProduccionForm";
            this.Text = "Mantenimiento Procedimiento de Producción";
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup.Panel)).EndInit();
            this.BaseFormHeaderGroup.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup)).EndInit();
            this.BaseFormHeaderGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.procedimientoProduccionViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridHeaderGroup.Panel)).EndInit();
            this.GridHeaderGroup.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridHeaderGroup)).EndInit();
            this.GridHeaderGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procedimientoProduccionInsumoViewModelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadMedidaViewModelBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox cantidadTextBox;
        private System.Windows.Forms.BindingSource procedimientoProduccionViewModelBindingSource;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.ComboBox unidadMedidaIdComboBox;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup GridHeaderGroup;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup AgregarDetalleButton;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup ModificarDetalleButton;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup EliminarDetalleButton;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView DetalleDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoMercaderiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreMercaderiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadMedidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource procedimientoProduccionInsumoViewModelsBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox mercaderiaTextBox;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny BuscarMercaderiaButton;
        private System.Windows.Forms.BindingSource unidadMedidaViewModelBindingSource;
    }
}