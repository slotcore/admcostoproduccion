namespace AdmCostoProduccion.Windows.Procesos.CompraVenta.Compra
{
    partial class MntCompraForm
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
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label numeroDocumentoLabel;
            this.BaseFormHeaderGroup = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.centroLogisticoIdComboBox = new System.Windows.Forms.ComboBox();
            this.compraViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.centroLogisticoViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.numeroDocumentoTextBox = new System.Windows.Forms.TextBox();
            this.GridHeaderGroup = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.AgregarDetalleButton = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.ModificarDetalleButton = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.EliminarDetalleButton = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.DetalleDataGridView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.compraDetalleViewModelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BaseFormToolStrip = new System.Windows.Forms.ToolStrip();
            this.GrabarButton = new System.Windows.Forms.ToolStripButton();
            this.CancelarButton = new System.Windows.Forms.ToolStripButton();
            this.codigoMercaderiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreMercaderiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            centroLogisticoIdLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            numeroDocumentoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup.Panel)).BeginInit();
            this.BaseFormHeaderGroup.Panel.SuspendLayout();
            this.BaseFormHeaderGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compraViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centroLogisticoViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridHeaderGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridHeaderGroup.Panel)).BeginInit();
            this.GridHeaderGroup.Panel.SuspendLayout();
            this.GridHeaderGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraDetalleViewModelsBindingSource)).BeginInit();
            this.BaseFormToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // centroLogisticoIdLabel
            // 
            centroLogisticoIdLabel.AutoSize = true;
            centroLogisticoIdLabel.BackColor = System.Drawing.Color.Transparent;
            centroLogisticoIdLabel.Location = new System.Drawing.Point(14, 18);
            centroLogisticoIdLabel.Name = "centroLogisticoIdLabel";
            centroLogisticoIdLabel.Size = new System.Drawing.Size(86, 13);
            centroLogisticoIdLabel.TabIndex = 0;
            centroLogisticoIdLabel.Text = "Centro Logistico:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.BackColor = System.Drawing.Color.Transparent;
            descripcionLabel.Location = new System.Drawing.Point(14, 45);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 4;
            descripcionLabel.Text = "Descripcion:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.BackColor = System.Drawing.Color.Transparent;
            fechaLabel.Location = new System.Drawing.Point(417, 45);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 7;
            fechaLabel.Text = "Fecha:";
            // 
            // numeroDocumentoLabel
            // 
            numeroDocumentoLabel.AutoSize = true;
            numeroDocumentoLabel.BackColor = System.Drawing.Color.Transparent;
            numeroDocumentoLabel.Location = new System.Drawing.Point(417, 18);
            numeroDocumentoLabel.Name = "numeroDocumentoLabel";
            numeroDocumentoLabel.Size = new System.Drawing.Size(105, 13);
            numeroDocumentoLabel.TabIndex = 2;
            numeroDocumentoLabel.Text = "Numero Documento:";
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
            this.BaseFormHeaderGroup.TabIndex = 25;
            this.BaseFormHeaderGroup.ValuesPrimary.Heading = "Mantenimiento Compra";
            this.BaseFormHeaderGroup.ValuesPrimary.Image = null;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.AutoScroll = true;
            this.kryptonPanel1.Controls.Add(centroLogisticoIdLabel);
            this.kryptonPanel1.Controls.Add(this.centroLogisticoIdComboBox);
            this.kryptonPanel1.Controls.Add(descripcionLabel);
            this.kryptonPanel1.Controls.Add(this.descripcionTextBox);
            this.kryptonPanel1.Controls.Add(fechaLabel);
            this.kryptonPanel1.Controls.Add(this.fechaDateTimePicker);
            this.kryptonPanel1.Controls.Add(numeroDocumentoLabel);
            this.kryptonPanel1.Controls.Add(this.numeroDocumentoTextBox);
            this.kryptonPanel1.Controls.Add(this.GridHeaderGroup);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(798, 395);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // centroLogisticoIdComboBox
            // 
            this.centroLogisticoIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compraViewModelBindingSource, "CentroLogisticoId", true));
            this.centroLogisticoIdComboBox.DataSource = this.centroLogisticoViewModelBindingSource;
            this.centroLogisticoIdComboBox.DisplayMember = "Nombre";
            this.centroLogisticoIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.centroLogisticoIdComboBox.FormattingEnabled = true;
            this.centroLogisticoIdComboBox.Location = new System.Drawing.Point(125, 15);
            this.centroLogisticoIdComboBox.Name = "centroLogisticoIdComboBox";
            this.centroLogisticoIdComboBox.Size = new System.Drawing.Size(259, 21);
            this.centroLogisticoIdComboBox.TabIndex = 1;
            this.centroLogisticoIdComboBox.ValueMember = "CentroLogisticoId";
            // 
            // compraViewModelBindingSource
            // 
            this.compraViewModelBindingSource.DataSource = typeof(AdmCostoProduccion.Common.ViewModels.CompraVenta.CompraViewModel);
            // 
            // centroLogisticoViewModelBindingSource
            // 
            this.centroLogisticoViewModelBindingSource.DataSource = typeof(AdmCostoProduccion.Common.ViewModels.Maestro.CentroLogisticoViewModel);
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compraViewModelBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(125, 42);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(259, 20);
            this.descripcionTextBox.TabIndex = 5;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.compraViewModelBindingSource, "Fecha", true));
            this.fechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(528, 42);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(130, 20);
            this.fechaDateTimePicker.TabIndex = 8;
            // 
            // numeroDocumentoTextBox
            // 
            this.numeroDocumentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compraViewModelBindingSource, "NumeroDocumento", true));
            this.numeroDocumentoTextBox.Location = new System.Drawing.Point(528, 16);
            this.numeroDocumentoTextBox.Name = "numeroDocumentoTextBox";
            this.numeroDocumentoTextBox.Size = new System.Drawing.Size(259, 20);
            this.numeroDocumentoTextBox.TabIndex = 3;
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
            this.GridHeaderGroup.Location = new System.Drawing.Point(2, 80);
            this.GridHeaderGroup.Margin = new System.Windows.Forms.Padding(2);
            this.GridHeaderGroup.Name = "GridHeaderGroup";
            // 
            // GridHeaderGroup.Panel
            // 
            this.GridHeaderGroup.Panel.Controls.Add(this.DetalleDataGridView);
            this.GridHeaderGroup.Size = new System.Drawing.Size(794, 314);
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
            this.UnidadMedida,
            this.cantidadDataGridViewTextBoxColumn,
            this.precioUnitarioDataGridViewTextBoxColumn,
            this.precioTotalDataGridViewTextBoxColumn});
            this.DetalleDataGridView.DataSource = this.compraDetalleViewModelsBindingSource;
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
            this.DetalleDataGridView.Size = new System.Drawing.Size(792, 285);
            this.DetalleDataGridView.TabIndex = 0;
            // 
            // compraDetalleViewModelsBindingSource
            // 
            this.compraDetalleViewModelsBindingSource.DataMember = "CompraDetalleViewModels";
            this.compraDetalleViewModelsBindingSource.DataSource = this.compraViewModelBindingSource;
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
            // UnidadMedida
            // 
            this.UnidadMedida.DataPropertyName = "UnidadMedida";
            this.UnidadMedida.HeaderText = "UnidadMedida";
            this.UnidadMedida.Name = "UnidadMedida";
            this.UnidadMedida.ReadOnly = true;
            this.UnidadMedida.Width = 114;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadDataGridViewTextBoxColumn.Width = 84;
            // 
            // precioUnitarioDataGridViewTextBoxColumn
            // 
            this.precioUnitarioDataGridViewTextBoxColumn.DataPropertyName = "PrecioUnitario";
            this.precioUnitarioDataGridViewTextBoxColumn.HeaderText = "PrecioUnitario";
            this.precioUnitarioDataGridViewTextBoxColumn.Name = "precioUnitarioDataGridViewTextBoxColumn";
            this.precioUnitarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioUnitarioDataGridViewTextBoxColumn.Width = 111;
            // 
            // precioTotalDataGridViewTextBoxColumn
            // 
            this.precioTotalDataGridViewTextBoxColumn.DataPropertyName = "PrecioTotal";
            this.precioTotalDataGridViewTextBoxColumn.HeaderText = "PrecioTotal";
            this.precioTotalDataGridViewTextBoxColumn.Name = "precioTotalDataGridViewTextBoxColumn";
            this.precioTotalDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioTotalDataGridViewTextBoxColumn.Width = 94;
            // 
            // MntCompraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BaseFormHeaderGroup);
            this.Controls.Add(this.BaseFormToolStrip);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MntCompraForm";
            this.Text = "Mantenimiento Compra";
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup.Panel)).EndInit();
            this.BaseFormHeaderGroup.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup)).EndInit();
            this.BaseFormHeaderGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compraViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centroLogisticoViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridHeaderGroup.Panel)).EndInit();
            this.GridHeaderGroup.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridHeaderGroup)).EndInit();
            this.GridHeaderGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraDetalleViewModelsBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource compraViewModelBindingSource;
        private System.Windows.Forms.ComboBox centroLogisticoIdComboBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.TextBox numeroDocumentoTextBox;
        private System.Windows.Forms.BindingSource compraDetalleViewModelsBindingSource;
        private System.Windows.Forms.BindingSource centroLogisticoViewModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoMercaderiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreMercaderiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioTotalDataGridViewTextBoxColumn;
    }
}