namespace AdmCostoProduccion.Windows.Mantenimiento.Inventario.Despacho
{
    partial class MntDespachoForm
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
            System.Windows.Forms.Label almacenIdLabel;
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label observacionLabel;
            System.Windows.Forms.Label tipoDespachoIdLabel;
            System.Windows.Forms.Label label1;
            this.BaseFormHeaderGroup = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.documentoRelacionadoTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.BuscarDocumentoButton = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.tipoDespachoTextBox = new System.Windows.Forms.TextBox();
            this.despachoViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.almacenIdComboBox = new System.Windows.Forms.ComboBox();
            this.almacenViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.observacionTextBox = new System.Windows.Forms.TextBox();
            this.GridHeaderGroup = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.AgregarDetalleButton = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.ModificarDetalleButton = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.EliminarDetalleButton = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.DetalleDataGridView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.BaseFormToolStrip = new System.Windows.Forms.ToolStrip();
            this.GrabarButton = new System.Windows.Forms.ToolStripButton();
            this.CancelarButton = new System.Windows.Forms.ToolStripButton();
            this.tipoDocumentoComboBox = new System.Windows.Forms.ComboBox();
            almacenIdLabel = new System.Windows.Forms.Label();
            codigoLabel = new System.Windows.Forms.Label();
            observacionLabel = new System.Windows.Forms.Label();
            tipoDespachoIdLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup.Panel)).BeginInit();
            this.BaseFormHeaderGroup.Panel.SuspendLayout();
            this.BaseFormHeaderGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.despachoViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridHeaderGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridHeaderGroup.Panel)).BeginInit();
            this.GridHeaderGroup.Panel.SuspendLayout();
            this.GridHeaderGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).BeginInit();
            this.BaseFormToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // almacenIdLabel
            // 
            almacenIdLabel.AutoSize = true;
            almacenIdLabel.BackColor = System.Drawing.Color.Transparent;
            almacenIdLabel.Location = new System.Drawing.Point(22, 29);
            almacenIdLabel.Name = "almacenIdLabel";
            almacenIdLabel.Size = new System.Drawing.Size(66, 17);
            almacenIdLabel.TabIndex = 12;
            almacenIdLabel.Text = "Almacen:";
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.BackColor = System.Drawing.Color.Transparent;
            codigoLabel.Location = new System.Drawing.Point(22, 118);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(56, 17);
            codigoLabel.TabIndex = 14;
            codigoLabel.Text = "Codigo:";
            // 
            // observacionLabel
            // 
            observacionLabel.AutoSize = true;
            observacionLabel.BackColor = System.Drawing.Color.Transparent;
            observacionLabel.Location = new System.Drawing.Point(22, 146);
            observacionLabel.Name = "observacionLabel";
            observacionLabel.Size = new System.Drawing.Size(92, 17);
            observacionLabel.TabIndex = 16;
            observacionLabel.Text = "Observacion:";
            // 
            // tipoDespachoIdLabel
            // 
            tipoDespachoIdLabel.AutoSize = true;
            tipoDespachoIdLabel.BackColor = System.Drawing.Color.Transparent;
            tipoDespachoIdLabel.Location = new System.Drawing.Point(22, 86);
            tipoDespachoIdLabel.Name = "tipoDespachoIdLabel";
            tipoDespachoIdLabel.Size = new System.Drawing.Size(108, 17);
            tipoDespachoIdLabel.TabIndex = 20;
            tipoDespachoIdLabel.Text = "Tipo Despacho:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Location = new System.Drawing.Point(22, 59);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(167, 17);
            label1.TabIndex = 22;
            label1.Text = "Documento Relacionado:";
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
            this.BaseFormHeaderGroup.TabIndex = 23;
            this.BaseFormHeaderGroup.ValuesPrimary.Heading = "Mantenimiento Despacho";
            this.BaseFormHeaderGroup.ValuesPrimary.Image = null;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.AutoScroll = true;
            this.kryptonPanel1.Controls.Add(this.tipoDocumentoComboBox);
            this.kryptonPanel1.Controls.Add(this.documentoRelacionadoTextBox);
            this.kryptonPanel1.Controls.Add(label1);
            this.kryptonPanel1.Controls.Add(this.tipoDespachoTextBox);
            this.kryptonPanel1.Controls.Add(almacenIdLabel);
            this.kryptonPanel1.Controls.Add(this.almacenIdComboBox);
            this.kryptonPanel1.Controls.Add(codigoLabel);
            this.kryptonPanel1.Controls.Add(this.codigoTextBox);
            this.kryptonPanel1.Controls.Add(observacionLabel);
            this.kryptonPanel1.Controls.Add(this.observacionTextBox);
            this.kryptonPanel1.Controls.Add(tipoDespachoIdLabel);
            this.kryptonPanel1.Controls.Add(this.GridHeaderGroup);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1065, 495);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // documentoRelacionadoTextBox
            // 
            this.documentoRelacionadoTextBox.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.BuscarDocumentoButton});
            this.documentoRelacionadoTextBox.Location = new System.Drawing.Point(403, 55);
            this.documentoRelacionadoTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.documentoRelacionadoTextBox.Name = "documentoRelacionadoTextBox";
            this.documentoRelacionadoTextBox.Size = new System.Drawing.Size(368, 27);
            this.documentoRelacionadoTextBox.TabIndex = 24;
            // 
            // BuscarDocumentoButton
            // 
            this.BuscarDocumentoButton.Image = global::AdmCostoProduccion.Windows.Properties.Resources.lookup_reference_16x16;
            this.BuscarDocumentoButton.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Inherit;
            this.BuscarDocumentoButton.ToolTipStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ToolTip;
            this.BuscarDocumentoButton.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Generic;
            this.BuscarDocumentoButton.UniqueName = "020B794215794657138ECD623B884FE9";
            this.BuscarDocumentoButton.Click += new System.EventHandler(this.BuscarDocumentoButton_Click);
            // 
            // tipoDespachoTextBox
            // 
            this.tipoDespachoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.despachoViewModelBindingSource, "TipoDespacho", true));
            this.tipoDespachoTextBox.Location = new System.Drawing.Point(197, 87);
            this.tipoDespachoTextBox.Name = "tipoDespachoTextBox";
            this.tipoDespachoTextBox.ReadOnly = true;
            this.tipoDespachoTextBox.Size = new System.Drawing.Size(574, 22);
            this.tipoDespachoTextBox.TabIndex = 23;
            // 
            // despachoViewModelBindingSource
            // 
            this.despachoViewModelBindingSource.DataSource = typeof(AdmCostoProduccion.Common.ViewModels.Inventario.DespachoViewModel);
            // 
            // almacenIdComboBox
            // 
            this.almacenIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.despachoViewModelBindingSource, "AlmacenId", true));
            this.almacenIdComboBox.DataSource = this.almacenViewModelBindingSource;
            this.almacenIdComboBox.DisplayMember = "Nombre";
            this.almacenIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.almacenIdComboBox.FormattingEnabled = true;
            this.almacenIdComboBox.Location = new System.Drawing.Point(197, 26);
            this.almacenIdComboBox.Name = "almacenIdComboBox";
            this.almacenIdComboBox.Size = new System.Drawing.Size(574, 24);
            this.almacenIdComboBox.TabIndex = 13;
            this.almacenIdComboBox.ValueMember = "AlmacenId";
            // 
            // almacenViewModelBindingSource
            // 
            this.almacenViewModelBindingSource.DataSource = typeof(AdmCostoProduccion.Common.ViewModels.Maestro.AlmacenViewModel);
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.despachoViewModelBindingSource, "Codigo", true));
            this.codigoTextBox.Location = new System.Drawing.Point(197, 115);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(574, 22);
            this.codigoTextBox.TabIndex = 15;
            // 
            // observacionTextBox
            // 
            this.observacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.despachoViewModelBindingSource, "Observacion", true));
            this.observacionTextBox.Location = new System.Drawing.Point(197, 143);
            this.observacionTextBox.Name = "observacionTextBox";
            this.observacionTextBox.Size = new System.Drawing.Size(574, 22);
            this.observacionTextBox.TabIndex = 17;
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
            this.GridHeaderGroup.Location = new System.Drawing.Point(3, 184);
            this.GridHeaderGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GridHeaderGroup.Name = "GridHeaderGroup";
            // 
            // GridHeaderGroup.Panel
            // 
            this.GridHeaderGroup.Panel.Controls.Add(this.DetalleDataGridView);
            this.GridHeaderGroup.Size = new System.Drawing.Size(1060, 310);
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
            this.AgregarDetalleButton.Click += new System.EventHandler(this.AgregarDetalleButton_Click);
            // 
            // ModificarDetalleButton
            // 
            this.ModificarDetalleButton.Image = global::AdmCostoProduccion.Windows.Properties.Resources.edit_16x16;
            this.ModificarDetalleButton.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Inherit;
            this.ModificarDetalleButton.Text = "Modificar";
            this.ModificarDetalleButton.ToolTipStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ToolTip;
            this.ModificarDetalleButton.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Generic;
            this.ModificarDetalleButton.UniqueName = "009B345D26464BC335B34D4F624BA8C4";
            this.ModificarDetalleButton.Click += new System.EventHandler(this.ModificarDetalleButton_Click);
            // 
            // EliminarDetalleButton
            // 
            this.EliminarDetalleButton.Image = global::AdmCostoProduccion.Windows.Properties.Resources.trash_16x16;
            this.EliminarDetalleButton.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Inherit;
            this.EliminarDetalleButton.Text = "Eliminar";
            this.EliminarDetalleButton.ToolTipStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ToolTip;
            this.EliminarDetalleButton.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Generic;
            this.EliminarDetalleButton.UniqueName = "4177A44FBE3B48B414A2BA528F1EEA82";
            this.EliminarDetalleButton.Click += new System.EventHandler(this.EliminarDetalleButton_Click);
            // 
            // DetalleDataGridView
            // 
            this.DetalleDataGridView.AllowUserToAddRows = false;
            this.DetalleDataGridView.AllowUserToDeleteRows = false;
            this.DetalleDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DetalleDataGridView.ColumnHeadersHeight = 25;
            this.DetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
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
            this.DetalleDataGridView.Size = new System.Drawing.Size(1058, 277);
            this.DetalleDataGridView.TabIndex = 0;
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
            this.BaseFormToolStrip.TabIndex = 22;
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
            // tipoDocumentoComboBox
            // 
            this.tipoDocumentoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoDocumentoComboBox.FormattingEnabled = true;
            this.tipoDocumentoComboBox.Location = new System.Drawing.Point(197, 55);
            this.tipoDocumentoComboBox.Name = "tipoDocumentoComboBox";
            this.tipoDocumentoComboBox.Size = new System.Drawing.Size(200, 24);
            this.tipoDocumentoComboBox.TabIndex = 25;
            // 
            // MntDespachoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.BaseFormHeaderGroup);
            this.Controls.Add(this.BaseFormToolStrip);
            this.Name = "MntDespachoForm";
            this.Text = "Mantenimiento Despacho";
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup.Panel)).EndInit();
            this.BaseFormHeaderGroup.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup)).EndInit();
            this.BaseFormHeaderGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.despachoViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridHeaderGroup.Panel)).EndInit();
            this.GridHeaderGroup.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridHeaderGroup)).EndInit();
            this.GridHeaderGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).EndInit();
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
        private System.Windows.Forms.TextBox tipoDespachoTextBox;
        private System.Windows.Forms.BindingSource despachoViewModelBindingSource;
        private System.Windows.Forms.ComboBox almacenIdComboBox;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.TextBox observacionTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox documentoRelacionadoTextBox;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny BuscarDocumentoButton;
        private System.Windows.Forms.BindingSource almacenViewModelBindingSource;
        private System.Windows.Forms.ComboBox tipoDocumentoComboBox;
    }
}