﻿namespace AdmCostoProduccion.Windows.Procesos.Inventario.Despacho
{
    partial class LstDespachoForm
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
            this.BaseFormToolStrip = new System.Windows.Forms.ToolStrip();
            this.AgregarButton = new System.Windows.Forms.ToolStripButton();
            this.ModificarButton = new System.Windows.Forms.ToolStripButton();
            this.EliminarButton = new System.Windows.Forms.ToolStripButton();
            this.ActualizarButton = new System.Windows.Forms.ToolStripButton();
            this.CargarExcelButton = new System.Windows.Forms.ToolStripButton();
            this.despachoViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDespachoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.almacenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDocumentoRelacionadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDocumentoRelacionadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.BaseFormToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.despachoViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BaseFormHeaderGroup
            // 
            this.BaseFormHeaderGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BaseFormHeaderGroup.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Calendar;
            this.BaseFormHeaderGroup.HeaderStyleSecondary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Form;
            this.BaseFormHeaderGroup.HeaderVisibleSecondary = false;
            this.BaseFormHeaderGroup.Location = new System.Drawing.Point(0, 29);
            this.BaseFormHeaderGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BaseFormHeaderGroup.Name = "BaseFormHeaderGroup";
            // 
            // BaseFormHeaderGroup.Panel
            // 
            this.BaseFormHeaderGroup.Panel.Controls.Add(this.kryptonPanel1);
            this.BaseFormHeaderGroup.Size = new System.Drawing.Size(1067, 525);
            this.BaseFormHeaderGroup.StateNormal.HeaderPrimary.Border.Color1 = System.Drawing.SystemColors.ControlDarkDark;
            this.BaseFormHeaderGroup.StateNormal.HeaderPrimary.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.BaseFormHeaderGroup.StateNormal.HeaderPrimary.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.BaseFormHeaderGroup.StateNormal.HeaderPrimary.Border.Width = 1;
            this.BaseFormHeaderGroup.TabIndex = 14;
            this.BaseFormHeaderGroup.ValuesPrimary.Heading = "Despacho";
            this.BaseFormHeaderGroup.ValuesPrimary.Image = null;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.BusquedaGroupBox);
            this.kryptonPanel1.Controls.Add(this.GridHeaderGroup);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1065, 497);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // BusquedaGroupBox
            // 
            this.BusquedaGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BusquedaGroupBox.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.GroupBoxCaption;
            this.BusquedaGroupBox.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlGroupBox;
            this.BusquedaGroupBox.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ControlGroupBox;
            this.BusquedaGroupBox.Location = new System.Drawing.Point(4, 2);
            this.BusquedaGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BusquedaGroupBox.Name = "BusquedaGroupBox";
            // 
            // BusquedaGroupBox.Panel
            // 
            this.BusquedaGroupBox.Panel.Controls.Add(this.BuscarButton);
            this.BusquedaGroupBox.Panel.Controls.Add(this.BusquedaTextBox);
            this.BusquedaGroupBox.Size = new System.Drawing.Size(1057, 135);
            this.BusquedaGroupBox.TabIndex = 2;
            this.BusquedaGroupBox.Values.Heading = "Busqueda";
            // 
            // BuscarButton
            // 
            this.BuscarButton.AutoSize = true;
            this.BuscarButton.Location = new System.Drawing.Point(539, 37);
            this.BuscarButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(97, 34);
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
            this.BusquedaTextBox.Location = new System.Drawing.Point(23, 39);
            this.BusquedaTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BusquedaTextBox.Name = "BusquedaTextBox";
            this.BusquedaTextBox.Size = new System.Drawing.Size(509, 27);
            this.BusquedaTextBox.TabIndex = 2;
            this.BusquedaTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BusquedaTextBox_KeyUp);
            // 
            // ClearButton
            // 
            this.ClearButton.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Inherit;
            this.ClearButton.ToolTipStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ToolTip;
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
            this.GridHeaderGroup.Location = new System.Drawing.Point(3, 145);
            this.GridHeaderGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GridHeaderGroup.Name = "GridHeaderGroup";
            // 
            // GridHeaderGroup.Panel
            // 
            this.GridHeaderGroup.Panel.Controls.Add(this.AlmacenDataGridView);
            this.GridHeaderGroup.Size = new System.Drawing.Size(1060, 348);
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
            this.codigoDataGridViewTextBoxColumn,
            this.tipoDespachoDataGridViewTextBoxColumn,
            this.almacenDataGridViewTextBoxColumn,
            this.tipoDocumentoRelacionadoDataGridViewTextBoxColumn,
            this.numeroDocumentoRelacionadoDataGridViewTextBoxColumn,
            this.observacionDataGridViewTextBoxColumn});
            this.AlmacenDataGridView.DataSource = this.despachoViewModelBindingSource;
            this.AlmacenDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AlmacenDataGridView.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.AlmacenDataGridView.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.AlmacenDataGridView.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.AlmacenDataGridView.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.AlmacenDataGridView.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.AlmacenDataGridView.Location = new System.Drawing.Point(0, 0);
            this.AlmacenDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AlmacenDataGridView.Name = "AlmacenDataGridView";
            this.AlmacenDataGridView.ReadOnly = true;
            this.AlmacenDataGridView.RowHeadersVisible = false;
            this.AlmacenDataGridView.RowHeadersWidth = 51;
            this.AlmacenDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.AlmacenDataGridView.Size = new System.Drawing.Size(1058, 320);
            this.AlmacenDataGridView.TabIndex = 0;
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
            this.BaseFormToolStrip.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.BaseFormToolStrip.Size = new System.Drawing.Size(1067, 29);
            this.BaseFormToolStrip.TabIndex = 13;
            this.BaseFormToolStrip.Text = "BaseFormToolStrip";
            // 
            // AgregarButton
            // 
            this.AgregarButton.Image = global::AdmCostoProduccion.Windows.Properties.Resources.add_16x16;
            this.AgregarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(87, 24);
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // ModificarButton
            // 
            this.ModificarButton.Image = global::AdmCostoProduccion.Windows.Properties.Resources.edit_16x16;
            this.ModificarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(97, 24);
            this.ModificarButton.Text = "Modificar";
            this.ModificarButton.Click += new System.EventHandler(this.ModificarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = global::AdmCostoProduccion.Windows.Properties.Resources.trash_16x16;
            this.EliminarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(87, 24);
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // ActualizarButton
            // 
            this.ActualizarButton.Image = global::AdmCostoProduccion.Windows.Properties.Resources.refresh2_16x16;
            this.ActualizarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ActualizarButton.Name = "ActualizarButton";
            this.ActualizarButton.Size = new System.Drawing.Size(99, 24);
            this.ActualizarButton.Text = "Actualizar";
            this.ActualizarButton.Click += new System.EventHandler(this.ActualizarButton_Click);
            // 
            // CargarExcelButton
            // 
            this.CargarExcelButton.Image = global::AdmCostoProduccion.Windows.Properties.Resources.exporttoxls_16x16;
            this.CargarExcelButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CargarExcelButton.Name = "CargarExcelButton";
            this.CargarExcelButton.Size = new System.Drawing.Size(114, 24);
            this.CargarExcelButton.Text = "Cargal Excel";
            // 
            // despachoViewModelBindingSource
            // 
            this.despachoViewModelBindingSource.DataSource = typeof(AdmCostoProduccion.Common.ViewModels.Inventario.DespachoViewModel);
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoDataGridViewTextBoxColumn.Width = 91;
            // 
            // tipoDespachoDataGridViewTextBoxColumn
            // 
            this.tipoDespachoDataGridViewTextBoxColumn.DataPropertyName = "TipoDespacho";
            this.tipoDespachoDataGridViewTextBoxColumn.HeaderText = "TipoDespacho";
            this.tipoDespachoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipoDespachoDataGridViewTextBoxColumn.Name = "tipoDespachoDataGridViewTextBoxColumn";
            this.tipoDespachoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoDespachoDataGridViewTextBoxColumn.Width = 138;
            // 
            // almacenDataGridViewTextBoxColumn
            // 
            this.almacenDataGridViewTextBoxColumn.DataPropertyName = "Almacen";
            this.almacenDataGridViewTextBoxColumn.HeaderText = "Almacen";
            this.almacenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.almacenDataGridViewTextBoxColumn.Name = "almacenDataGridViewTextBoxColumn";
            this.almacenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDocumentoRelacionadoDataGridViewTextBoxColumn
            // 
            this.tipoDocumentoRelacionadoDataGridViewTextBoxColumn.DataPropertyName = "TipoDocumentoRelacionado";
            this.tipoDocumentoRelacionadoDataGridViewTextBoxColumn.HeaderText = "Tipo Documento";
            this.tipoDocumentoRelacionadoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipoDocumentoRelacionadoDataGridViewTextBoxColumn.Name = "tipoDocumentoRelacionadoDataGridViewTextBoxColumn";
            this.tipoDocumentoRelacionadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoDocumentoRelacionadoDataGridViewTextBoxColumn.Width = 154;
            // 
            // numeroDocumentoRelacionadoDataGridViewTextBoxColumn
            // 
            this.numeroDocumentoRelacionadoDataGridViewTextBoxColumn.DataPropertyName = "NumeroDocumentoRelacionado";
            this.numeroDocumentoRelacionadoDataGridViewTextBoxColumn.HeaderText = "Numero Documento";
            this.numeroDocumentoRelacionadoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeroDocumentoRelacionadoDataGridViewTextBoxColumn.Name = "numeroDocumentoRelacionadoDataGridViewTextBoxColumn";
            this.numeroDocumentoRelacionadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroDocumentoRelacionadoDataGridViewTextBoxColumn.Width = 178;
            // 
            // observacionDataGridViewTextBoxColumn
            // 
            this.observacionDataGridViewTextBoxColumn.DataPropertyName = "Observacion";
            this.observacionDataGridViewTextBoxColumn.HeaderText = "Observacion";
            this.observacionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.observacionDataGridViewTextBoxColumn.Name = "observacionDataGridViewTextBoxColumn";
            this.observacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.observacionDataGridViewTextBoxColumn.Width = 124;
            // 
            // LstDespachoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.BaseFormHeaderGroup);
            this.Controls.Add(this.BaseFormToolStrip);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LstDespachoForm";
            this.Text = "Despacho";
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
            this.BaseFormToolStrip.ResumeLayout(false);
            this.BaseFormToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.despachoViewModelBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDespachoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn almacenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDocumentoRelacionadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDocumentoRelacionadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource despachoViewModelBindingSource;
    }
}