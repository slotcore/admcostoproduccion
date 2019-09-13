namespace AdmCostoProduccion.Windows.Procesos.CompraVenta.Venta
{
    partial class MntVentaDetalleForm
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
            System.Windows.Forms.Label precioTotalLabel;
            System.Windows.Forms.Label precioUnitarioLabel;
            System.Windows.Forms.Label mercaderiaIdLabel;
            System.Windows.Forms.Label unidadMedidaIdLabel;
            this.BaseFormHeaderGroup = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.unidadMedidaIdComboBox = new System.Windows.Forms.ComboBox();
            this.ventaDetalleViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unidadMedidaViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mercaderiaTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.BuscarMercaderiaButton = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.cantidadTextBox = new System.Windows.Forms.TextBox();
            this.precioTotalTextBox = new System.Windows.Forms.TextBox();
            this.precioUnitarioTextBox = new System.Windows.Forms.TextBox();
            this.BaseFormToolStrip = new System.Windows.Forms.ToolStrip();
            this.GrabarButton = new System.Windows.Forms.ToolStripButton();
            this.CancelarButton = new System.Windows.Forms.ToolStripButton();
            cantidadLabel = new System.Windows.Forms.Label();
            precioTotalLabel = new System.Windows.Forms.Label();
            precioUnitarioLabel = new System.Windows.Forms.Label();
            mercaderiaIdLabel = new System.Windows.Forms.Label();
            unidadMedidaIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup.Panel)).BeginInit();
            this.BaseFormHeaderGroup.Panel.SuspendLayout();
            this.BaseFormHeaderGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventaDetalleViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadMedidaViewModelBindingSource)).BeginInit();
            this.BaseFormToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.BackColor = System.Drawing.Color.Transparent;
            cantidadLabel.Location = new System.Drawing.Point(177, 190);
            cantidadLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(52, 13);
            cantidadLabel.TabIndex = 2;
            cantidadLabel.Text = "Cantidad:";
            // 
            // precioTotalLabel
            // 
            precioTotalLabel.AutoSize = true;
            precioTotalLabel.BackColor = System.Drawing.Color.Transparent;
            precioTotalLabel.Location = new System.Drawing.Point(177, 213);
            precioTotalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            precioTotalLabel.Name = "precioTotalLabel";
            precioTotalLabel.Size = new System.Drawing.Size(67, 13);
            precioTotalLabel.TabIndex = 4;
            precioTotalLabel.Text = "Precio Total:";
            // 
            // precioUnitarioLabel
            // 
            precioUnitarioLabel.AutoSize = true;
            precioUnitarioLabel.BackColor = System.Drawing.Color.Transparent;
            precioUnitarioLabel.Location = new System.Drawing.Point(177, 235);
            precioUnitarioLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            precioUnitarioLabel.Name = "precioUnitarioLabel";
            precioUnitarioLabel.Size = new System.Drawing.Size(79, 13);
            precioUnitarioLabel.TabIndex = 6;
            precioUnitarioLabel.Text = "Precio Unitario:";
            // 
            // mercaderiaIdLabel
            // 
            mercaderiaIdLabel.AutoSize = true;
            mercaderiaIdLabel.BackColor = System.Drawing.Color.Transparent;
            mercaderiaIdLabel.Location = new System.Drawing.Point(177, 136);
            mercaderiaIdLabel.Name = "mercaderiaIdLabel";
            mercaderiaIdLabel.Size = new System.Drawing.Size(63, 13);
            mercaderiaIdLabel.TabIndex = 0;
            mercaderiaIdLabel.Text = "Mercaderia:";
            // 
            // unidadMedidaIdLabel
            // 
            unidadMedidaIdLabel.AutoSize = true;
            unidadMedidaIdLabel.BackColor = System.Drawing.Color.Transparent;
            unidadMedidaIdLabel.Location = new System.Drawing.Point(178, 164);
            unidadMedidaIdLabel.Name = "unidadMedidaIdLabel";
            unidadMedidaIdLabel.Size = new System.Drawing.Size(82, 13);
            unidadMedidaIdLabel.TabIndex = 8;
            unidadMedidaIdLabel.Text = "Unidad Medida:";
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
            this.BaseFormHeaderGroup.TabIndex = 15;
            this.BaseFormHeaderGroup.ValuesPrimary.Heading = "Mantenimiento Venta Detalle";
            this.BaseFormHeaderGroup.ValuesPrimary.Image = null;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(unidadMedidaIdLabel);
            this.kryptonPanel1.Controls.Add(this.unidadMedidaIdComboBox);
            this.kryptonPanel1.Controls.Add(this.mercaderiaTextBox);
            this.kryptonPanel1.Controls.Add(mercaderiaIdLabel);
            this.kryptonPanel1.Controls.Add(cantidadLabel);
            this.kryptonPanel1.Controls.Add(this.cantidadTextBox);
            this.kryptonPanel1.Controls.Add(precioTotalLabel);
            this.kryptonPanel1.Controls.Add(this.precioTotalTextBox);
            this.kryptonPanel1.Controls.Add(precioUnitarioLabel);
            this.kryptonPanel1.Controls.Add(this.precioUnitarioTextBox);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(798, 395);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // unidadMedidaIdComboBox
            // 
            this.unidadMedidaIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventaDetalleViewModelBindingSource, "UnidadMedidaId", true));
            this.unidadMedidaIdComboBox.DataSource = this.unidadMedidaViewModelBindingSource;
            this.unidadMedidaIdComboBox.DisplayMember = "Nombre";
            this.unidadMedidaIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unidadMedidaIdComboBox.FormattingEnabled = true;
            this.unidadMedidaIdComboBox.Location = new System.Drawing.Point(278, 161);
            this.unidadMedidaIdComboBox.Name = "unidadMedidaIdComboBox";
            this.unidadMedidaIdComboBox.Size = new System.Drawing.Size(365, 21);
            this.unidadMedidaIdComboBox.TabIndex = 9;
            this.unidadMedidaIdComboBox.ValueMember = "UnidadMedidaId";
            // 
            // ventaDetalleViewModelBindingSource
            // 
            this.ventaDetalleViewModelBindingSource.DataSource = typeof(AdmCostoProduccion.Common.ViewModels.CompraVenta.VentaDetalleViewModel);
            // 
            // unidadMedidaViewModelBindingSource
            // 
            this.unidadMedidaViewModelBindingSource.DataSource = typeof(AdmCostoProduccion.Common.ViewModels.Inventario.UnidadMedidaViewModel);
            // 
            // mercaderiaTextBox
            // 
            this.mercaderiaTextBox.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.BuscarMercaderiaButton});
            this.mercaderiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventaDetalleViewModelBindingSource, "NombreMercaderia", true));
            this.mercaderiaTextBox.Location = new System.Drawing.Point(278, 132);
            this.mercaderiaTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.mercaderiaTextBox.Name = "mercaderiaTextBox";
            this.mercaderiaTextBox.Size = new System.Drawing.Size(365, 24);
            this.mercaderiaTextBox.TabIndex = 1;
            // 
            // BuscarMercaderiaButton
            // 
            this.BuscarMercaderiaButton.Image = global::AdmCostoProduccion.Windows.Properties.Resources.lookup_reference_16x16;
            this.BuscarMercaderiaButton.UniqueName = "020B794215794657138ECD623B884FE9";
            this.BuscarMercaderiaButton.Click += new System.EventHandler(this.BuscarMercaderiaButton_Click);
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventaDetalleViewModelBindingSource, "Cantidad", true));
            this.cantidadTextBox.Location = new System.Drawing.Point(278, 187);
            this.cantidadTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(366, 20);
            this.cantidadTextBox.TabIndex = 3;
            // 
            // precioTotalTextBox
            // 
            this.precioTotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventaDetalleViewModelBindingSource, "PrecioTotal", true));
            this.precioTotalTextBox.Location = new System.Drawing.Point(278, 210);
            this.precioTotalTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.precioTotalTextBox.Name = "precioTotalTextBox";
            this.precioTotalTextBox.Size = new System.Drawing.Size(366, 20);
            this.precioTotalTextBox.TabIndex = 5;
            // 
            // precioUnitarioTextBox
            // 
            this.precioUnitarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventaDetalleViewModelBindingSource, "PrecioUnitario", true));
            this.precioUnitarioTextBox.Location = new System.Drawing.Point(278, 233);
            this.precioUnitarioTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.precioUnitarioTextBox.Name = "precioUnitarioTextBox";
            this.precioUnitarioTextBox.Size = new System.Drawing.Size(366, 20);
            this.precioUnitarioTextBox.TabIndex = 7;
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
            this.BaseFormToolStrip.TabIndex = 14;
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
            // MntVentaDetalleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BaseFormHeaderGroup);
            this.Controls.Add(this.BaseFormToolStrip);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MntVentaDetalleForm";
            this.Text = "Mantenimiento Venta Detalle";
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup.Panel)).EndInit();
            this.BaseFormHeaderGroup.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup)).EndInit();
            this.BaseFormHeaderGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventaDetalleViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadMedidaViewModelBindingSource)).EndInit();
            this.BaseFormToolStrip.ResumeLayout(false);
            this.BaseFormToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup BaseFormHeaderGroup;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.TextBox cantidadTextBox;
        private System.Windows.Forms.BindingSource ventaDetalleViewModelBindingSource;
        private System.Windows.Forms.TextBox precioTotalTextBox;
        private System.Windows.Forms.TextBox precioUnitarioTextBox;
        protected System.Windows.Forms.ToolStrip BaseFormToolStrip;
        private System.Windows.Forms.ToolStripButton GrabarButton;
        private System.Windows.Forms.ToolStripButton CancelarButton;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox mercaderiaTextBox;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny BuscarMercaderiaButton;
        private System.Windows.Forms.ComboBox unidadMedidaIdComboBox;
        private System.Windows.Forms.BindingSource unidadMedidaViewModelBindingSource;
    }
}