﻿namespace AdmCostoProduccion.Windows.Maestro.CentroLogistico
{
    partial class LstCentroLogisticoForm
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
            this.BaseFormToolStrip = new System.Windows.Forms.ToolStrip();
            this.AgregarButton = new System.Windows.Forms.ToolStripButton();
            this.ModificarButton = new System.Windows.Forms.ToolStripButton();
            this.EliminarButton = new System.Windows.Forms.ToolStripButton();
            this.ActualizarButton = new System.Windows.Forms.ToolStripButton();
            this.CargarExcelButton = new System.Windows.Forms.ToolStripButton();
            this.BaseFormHeaderGroup = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.GridHeaderGroup = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.CentroLogisticoDataGridView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.centroLogisticoViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaseFormToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup.Panel)).BeginInit();
            this.BaseFormHeaderGroup.Panel.SuspendLayout();
            this.BaseFormHeaderGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridHeaderGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridHeaderGroup.Panel)).BeginInit();
            this.GridHeaderGroup.Panel.SuspendLayout();
            this.GridHeaderGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CentroLogisticoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centroLogisticoViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.BaseFormToolStrip.Size = new System.Drawing.Size(1056, 29);
            this.BaseFormToolStrip.TabIndex = 1;
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
            // BaseFormHeaderGroup
            // 
            this.BaseFormHeaderGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BaseFormHeaderGroup.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Calendar;
            this.BaseFormHeaderGroup.HeaderStyleSecondary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Form;
            this.BaseFormHeaderGroup.HeaderVisibleSecondary = false;
            this.BaseFormHeaderGroup.Location = new System.Drawing.Point(0, 29);
            this.BaseFormHeaderGroup.Name = "BaseFormHeaderGroup";
            // 
            // BaseFormHeaderGroup.Panel
            // 
            this.BaseFormHeaderGroup.Panel.Controls.Add(this.kryptonPanel1);
            this.BaseFormHeaderGroup.Size = new System.Drawing.Size(1056, 583);
            this.BaseFormHeaderGroup.StateNormal.HeaderPrimary.Border.Color1 = System.Drawing.SystemColors.ControlDarkDark;
            this.BaseFormHeaderGroup.StateNormal.HeaderPrimary.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.BaseFormHeaderGroup.StateNormal.HeaderPrimary.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.BaseFormHeaderGroup.StateNormal.HeaderPrimary.Border.Width = 1;
            this.BaseFormHeaderGroup.TabIndex = 2;
            this.BaseFormHeaderGroup.ValuesPrimary.Heading = "Centro Logístico";
            this.BaseFormHeaderGroup.ValuesPrimary.Image = null;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.GridHeaderGroup);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1054, 555);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // GridHeaderGroup
            // 
            this.GridHeaderGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridHeaderGroup.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.DockActive;
            this.GridHeaderGroup.HeaderVisibleSecondary = false;
            this.GridHeaderGroup.Location = new System.Drawing.Point(3, 145);
            this.GridHeaderGroup.Name = "GridHeaderGroup";
            // 
            // GridHeaderGroup.Panel
            // 
            this.GridHeaderGroup.Panel.Controls.Add(this.CentroLogisticoDataGridView);
            this.GridHeaderGroup.Size = new System.Drawing.Size(1048, 407);
            this.GridHeaderGroup.TabIndex = 0;
            this.GridHeaderGroup.ValuesPrimary.Heading = "Detalles";
            this.GridHeaderGroup.ValuesPrimary.Image = null;
            // 
            // CentroLogisticoDataGridView
            // 
            this.CentroLogisticoDataGridView.AllowUserToAddRows = false;
            this.CentroLogisticoDataGridView.AllowUserToDeleteRows = false;
            this.CentroLogisticoDataGridView.AutoGenerateColumns = false;
            this.CentroLogisticoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CentroLogisticoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn});
            this.CentroLogisticoDataGridView.DataSource = this.centroLogisticoViewModelBindingSource;
            this.CentroLogisticoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CentroLogisticoDataGridView.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.CentroLogisticoDataGridView.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.CentroLogisticoDataGridView.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.CentroLogisticoDataGridView.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.CentroLogisticoDataGridView.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.CentroLogisticoDataGridView.Location = new System.Drawing.Point(0, 0);
            this.CentroLogisticoDataGridView.Name = "CentroLogisticoDataGridView";
            this.CentroLogisticoDataGridView.ReadOnly = true;
            this.CentroLogisticoDataGridView.RowHeadersVisible = false;
            this.CentroLogisticoDataGridView.RowHeadersWidth = 51;
            this.CentroLogisticoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.CentroLogisticoDataGridView.Size = new System.Drawing.Size(1046, 379);
            this.CentroLogisticoDataGridView.TabIndex = 0;
            // 
            // centroLogisticoViewModelBindingSource
            // 
            this.centroLogisticoViewModelBindingSource.DataSource = typeof(AdmCostoProduccion.Common.ViewModels.Maestro.CentroLogisticoViewModel);
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 125;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn.Width = 125;
            // 
            // LstCentroLogisticoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 612);
            this.Controls.Add(this.BaseFormHeaderGroup);
            this.Controls.Add(this.BaseFormToolStrip);
            this.Name = "LstCentroLogisticoForm";
            this.Text = "Centro Logístico";
            this.BaseFormToolStrip.ResumeLayout(false);
            this.BaseFormToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup.Panel)).EndInit();
            this.BaseFormHeaderGroup.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup)).EndInit();
            this.BaseFormHeaderGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridHeaderGroup.Panel)).EndInit();
            this.GridHeaderGroup.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridHeaderGroup)).EndInit();
            this.GridHeaderGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CentroLogisticoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centroLogisticoViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.ToolStrip BaseFormToolStrip;
        private System.Windows.Forms.ToolStripButton AgregarButton;
        private System.Windows.Forms.ToolStripButton ModificarButton;
        private System.Windows.Forms.ToolStripButton EliminarButton;
        private System.Windows.Forms.ToolStripButton ActualizarButton;
        private System.Windows.Forms.ToolStripButton CargarExcelButton;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup BaseFormHeaderGroup;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup GridHeaderGroup;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView CentroLogisticoDataGridView;
        private System.Windows.Forms.BindingSource centroLogisticoViewModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
    }
}