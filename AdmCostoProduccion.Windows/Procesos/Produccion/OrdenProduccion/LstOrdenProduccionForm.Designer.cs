namespace AdmCostoProduccion.Windows.Procesos.Produccion.OrdenProduccion
{
    partial class LstOrdenProduccionForm
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
            this.BaseFormHeaderGroup = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.BusquedaGroupBox = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.BuscarButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BusquedaTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ClearButton = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.GridHeaderGroup = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.AlmacenDataGridView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.plantaFabricacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoMercaderiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreMercaderiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procedimientoProduccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadMedidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordenProduccionViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BaseFormToolStrip = new System.Windows.Forms.ToolStrip();
            this.AgregarButton = new System.Windows.Forms.ToolStripButton();
            this.ModificarButton = new System.Windows.Forms.ToolStripButton();
            this.EliminarButton = new System.Windows.Forms.ToolStripButton();
            this.ActualizarButton = new System.Windows.Forms.ToolStripButton();
            this.CargarExcelButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup.Panel)).BeginInit();
            this.BaseFormHeaderGroup.Panel.SuspendLayout();
            this.BaseFormHeaderGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BusquedaGroupBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BusquedaGroupBox.Panel)).BeginInit();
            this.BusquedaGroupBox.Panel.SuspendLayout();
            this.BusquedaGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridHeaderGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridHeaderGroup.Panel)).BeginInit();
            this.GridHeaderGroup.Panel.SuspendLayout();
            this.GridHeaderGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlmacenDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenProduccionViewModelBindingSource)).BeginInit();
            this.BaseFormToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // BaseFormHeaderGroup
            // 
            this.BaseFormHeaderGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BaseFormHeaderGroup.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Calendar;
            this.BaseFormHeaderGroup.HeaderStyleSecondary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Form;
            this.BaseFormHeaderGroup.HeaderVisibleSecondary = false;
            this.BaseFormHeaderGroup.Location = new System.Drawing.Point(0, 29);
            this.BaseFormHeaderGroup.Margin = new System.Windows.Forms.Padding(2);
            this.BaseFormHeaderGroup.Name = "BaseFormHeaderGroup";
            // 
            // BaseFormHeaderGroup.Panel
            // 
            this.BaseFormHeaderGroup.Panel.Controls.Add(this.kryptonPanel1);
            this.BaseFormHeaderGroup.Size = new System.Drawing.Size(800, 421);
            this.BaseFormHeaderGroup.StateNormal.HeaderPrimary.Border.Color1 = System.Drawing.SystemColors.ControlDarkDark;
            this.BaseFormHeaderGroup.StateNormal.HeaderPrimary.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.BaseFormHeaderGroup.StateNormal.HeaderPrimary.Border.Width = 1;
            this.BaseFormHeaderGroup.TabIndex = 18;
            this.BaseFormHeaderGroup.ValuesPrimary.Heading = "Orden de Producción";
            this.BaseFormHeaderGroup.ValuesPrimary.Image = null;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.BusquedaGroupBox);
            this.kryptonPanel1.Controls.Add(this.GridHeaderGroup);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(798, 397);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // BusquedaGroupBox
            // 
            this.BusquedaGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BusquedaGroupBox.Location = new System.Drawing.Point(3, 2);
            this.BusquedaGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.BusquedaGroupBox.Name = "BusquedaGroupBox";
            // 
            // BusquedaGroupBox.Panel
            // 
            this.BusquedaGroupBox.Panel.Controls.Add(this.BuscarButton);
            this.BusquedaGroupBox.Panel.Controls.Add(this.BusquedaTextBox);
            this.BusquedaGroupBox.Size = new System.Drawing.Size(792, 110);
            this.BusquedaGroupBox.TabIndex = 2;
            this.BusquedaGroupBox.Values.Heading = "Busqueda";
            // 
            // BuscarButton
            // 
            this.BuscarButton.AutoSize = true;
            this.BuscarButton.Location = new System.Drawing.Point(404, 30);
            this.BuscarButton.Margin = new System.Windows.Forms.Padding(2);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(73, 28);
            this.BuscarButton.TabIndex = 3;
            this.BuscarButton.Values.Image = global::AdmCostoProduccion.Windows.Properties.Resources.lookup_reference_16x16;
            this.BuscarButton.Values.Text = "Buscar";
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // BusquedaTextBox
            // 
            this.BusquedaTextBox.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.ClearButton});
            this.BusquedaTextBox.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon;
            this.BusquedaTextBox.Location = new System.Drawing.Point(17, 32);
            this.BusquedaTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.BusquedaTextBox.Name = "BusquedaTextBox";
            this.BusquedaTextBox.Size = new System.Drawing.Size(382, 23);
            this.BusquedaTextBox.TabIndex = 2;
            this.BusquedaTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BusquedaTextBox_KeyUp);
            // 
            // ClearButton
            // 
            this.ClearButton.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.ClearButton.UniqueName = "1108868230D14A995A9EC71B7814ACBA";
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // GridHeaderGroup
            // 
            this.GridHeaderGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridHeaderGroup.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.DockActive;
            this.GridHeaderGroup.HeaderVisibleSecondary = false;
            this.GridHeaderGroup.Location = new System.Drawing.Point(2, 118);
            this.GridHeaderGroup.Margin = new System.Windows.Forms.Padding(2);
            this.GridHeaderGroup.Name = "GridHeaderGroup";
            // 
            // GridHeaderGroup.Panel
            // 
            this.GridHeaderGroup.Panel.Controls.Add(this.AlmacenDataGridView);
            this.GridHeaderGroup.Size = new System.Drawing.Size(794, 276);
            this.GridHeaderGroup.TabIndex = 0;
            this.GridHeaderGroup.ValuesPrimary.Heading = "Detalles";
            this.GridHeaderGroup.ValuesPrimary.Image = null;
            // 
            // AlmacenDataGridView
            // 
            this.AlmacenDataGridView.AllowUserToAddRows = false;
            this.AlmacenDataGridView.AllowUserToDeleteRows = false;
            this.AlmacenDataGridView.AutoGenerateColumns = false;
            this.AlmacenDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.AlmacenDataGridView.ColumnHeadersHeight = 25;
            this.AlmacenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.AlmacenDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.plantaFabricacionDataGridViewTextBoxColumn,
            this.codigoDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.codigoMercaderiaDataGridViewTextBoxColumn,
            this.nombreMercaderiaDataGridViewTextBoxColumn,
            this.procedimientoProduccionDataGridViewTextBoxColumn,
            this.unidadMedidaDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.loteDataGridViewTextBoxColumn});
            this.AlmacenDataGridView.DataSource = this.ordenProduccionViewModelBindingSource;
            this.AlmacenDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AlmacenDataGridView.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.AlmacenDataGridView.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.AlmacenDataGridView.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.AlmacenDataGridView.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.AlmacenDataGridView.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.AlmacenDataGridView.Location = new System.Drawing.Point(0, 0);
            this.AlmacenDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.AlmacenDataGridView.Name = "AlmacenDataGridView";
            this.AlmacenDataGridView.ReadOnly = true;
            this.AlmacenDataGridView.RowHeadersVisible = false;
            this.AlmacenDataGridView.RowHeadersWidth = 51;
            this.AlmacenDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.AlmacenDataGridView.Size = new System.Drawing.Size(792, 252);
            this.AlmacenDataGridView.TabIndex = 0;
            // 
            // plantaFabricacionDataGridViewTextBoxColumn
            // 
            this.plantaFabricacionDataGridViewTextBoxColumn.DataPropertyName = "PlantaFabricacion";
            this.plantaFabricacionDataGridViewTextBoxColumn.HeaderText = "PlantaFabricacion";
            this.plantaFabricacionDataGridViewTextBoxColumn.Name = "plantaFabricacionDataGridViewTextBoxColumn";
            this.plantaFabricacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.plantaFabricacionDataGridViewTextBoxColumn.Width = 130;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoDataGridViewTextBoxColumn.Width = 75;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn.Width = 67;
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
            // loteDataGridViewTextBoxColumn
            // 
            this.loteDataGridViewTextBoxColumn.DataPropertyName = "Lote";
            this.loteDataGridViewTextBoxColumn.HeaderText = "Lote";
            this.loteDataGridViewTextBoxColumn.Name = "loteDataGridViewTextBoxColumn";
            this.loteDataGridViewTextBoxColumn.ReadOnly = true;
            this.loteDataGridViewTextBoxColumn.Width = 59;
            // 
            // ordenProduccionViewModelBindingSource
            // 
            this.ordenProduccionViewModelBindingSource.DataSource = typeof(AdmCostoProduccion.Common.ViewModels.Produccion.OrdenProduccionViewModel);
            // 
            // BaseFormToolStrip
            // 
            this.BaseFormToolStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BaseFormToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.BaseFormToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.BaseFormToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AgregarButton,
            this.ModificarButton,
            this.EliminarButton,
            this.ActualizarButton,
            this.CargarExcelButton});
            this.BaseFormToolStrip.Location = new System.Drawing.Point(0, 0);
            this.BaseFormToolStrip.Name = "BaseFormToolStrip";
            this.BaseFormToolStrip.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.BaseFormToolStrip.Size = new System.Drawing.Size(800, 29);
            this.BaseFormToolStrip.TabIndex = 17;
            this.BaseFormToolStrip.Text = "BaseFormToolStrip";
            // 
            // AgregarButton
            // 
            this.AgregarButton.Image = global::AdmCostoProduccion.Windows.Properties.Resources.add_16x16;
            this.AgregarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(73, 24);
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // ModificarButton
            // 
            this.ModificarButton.Image = global::AdmCostoProduccion.Windows.Properties.Resources.edit_16x16;
            this.ModificarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(82, 24);
            this.ModificarButton.Text = "Modificar";
            this.ModificarButton.Click += new System.EventHandler(this.ModificarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = global::AdmCostoProduccion.Windows.Properties.Resources.trash_16x16;
            this.EliminarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(74, 24);
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // ActualizarButton
            // 
            this.ActualizarButton.Image = global::AdmCostoProduccion.Windows.Properties.Resources.refresh2_16x16;
            this.ActualizarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ActualizarButton.Name = "ActualizarButton";
            this.ActualizarButton.Size = new System.Drawing.Size(83, 24);
            this.ActualizarButton.Text = "Actualizar";
            this.ActualizarButton.Click += new System.EventHandler(this.ActualizarButton_Click);
            // 
            // CargarExcelButton
            // 
            this.CargarExcelButton.Image = global::AdmCostoProduccion.Windows.Properties.Resources.exporttoxls_16x16;
            this.CargarExcelButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CargarExcelButton.Name = "CargarExcelButton";
            this.CargarExcelButton.Size = new System.Drawing.Size(95, 24);
            this.CargarExcelButton.Text = "Cargal Excel";
            // 
            // LstOrdenProduccionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BaseFormHeaderGroup);
            this.Controls.Add(this.BaseFormToolStrip);
            this.Name = "LstOrdenProduccionForm";
            this.Text = "Orden de Producción";
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup.Panel)).EndInit();
            this.BaseFormHeaderGroup.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup)).EndInit();
            this.BaseFormHeaderGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BusquedaGroupBox.Panel)).EndInit();
            this.BusquedaGroupBox.Panel.ResumeLayout(false);
            this.BusquedaGroupBox.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BusquedaGroupBox)).EndInit();
            this.BusquedaGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridHeaderGroup.Panel)).EndInit();
            this.GridHeaderGroup.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridHeaderGroup)).EndInit();
            this.GridHeaderGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AlmacenDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenProduccionViewModelBindingSource)).EndInit();
            this.BaseFormToolStrip.ResumeLayout(false);
            this.BaseFormToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup BaseFormHeaderGroup;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox BusquedaGroupBox;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BuscarButton;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox BusquedaTextBox;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny ClearButton;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup GridHeaderGroup;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView AlmacenDataGridView;
        protected System.Windows.Forms.ToolStrip BaseFormToolStrip;
        private System.Windows.Forms.ToolStripButton AgregarButton;
        private System.Windows.Forms.ToolStripButton ModificarButton;
        private System.Windows.Forms.ToolStripButton EliminarButton;
        private System.Windows.Forms.ToolStripButton ActualizarButton;
        private System.Windows.Forms.ToolStripButton CargarExcelButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn plantaFabricacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoMercaderiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreMercaderiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn procedimientoProduccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadMedidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loteDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ordenProduccionViewModelBindingSource;
    }
}