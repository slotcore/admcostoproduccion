namespace AdmCostoProduccion.Windows.Procesos.Inventario.AjusteInventario
{
    partial class MntAjusteInventarioDetalleForm
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
            System.Windows.Forms.Label mercaderiaIdLabel;
            System.Windows.Forms.Label cantidadLabel1;
            System.Windows.Forms.Label costoLabel;
            System.Windows.Forms.Label unidadMedidaLabel;
            this.BaseFormHeaderGroup = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.cantidadTextBox1 = new System.Windows.Forms.TextBox();
            this.ajusteInventarioDetalleViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.costoTextBox = new System.Windows.Forms.TextBox();
            this.unidadMedidaComboBox = new System.Windows.Forms.ComboBox();
            this.mercaderiaTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.BuscarMercaderiaButton = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.BaseFormToolStrip = new System.Windows.Forms.ToolStrip();
            this.GrabarButton = new System.Windows.Forms.ToolStripButton();
            this.CancelarButton = new System.Windows.Forms.ToolStripButton();
            this.unidadMedidaViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            mercaderiaIdLabel = new System.Windows.Forms.Label();
            cantidadLabel1 = new System.Windows.Forms.Label();
            costoLabel = new System.Windows.Forms.Label();
            unidadMedidaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup.Panel)).BeginInit();
            this.BaseFormHeaderGroup.Panel.SuspendLayout();
            this.BaseFormHeaderGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ajusteInventarioDetalleViewModelBindingSource)).BeginInit();
            this.BaseFormToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unidadMedidaViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mercaderiaIdLabel
            // 
            mercaderiaIdLabel.AutoSize = true;
            mercaderiaIdLabel.BackColor = System.Drawing.Color.Transparent;
            mercaderiaIdLabel.Location = new System.Drawing.Point(182, 135);
            mercaderiaIdLabel.Name = "mercaderiaIdLabel";
            mercaderiaIdLabel.Size = new System.Drawing.Size(63, 13);
            mercaderiaIdLabel.TabIndex = 0;
            mercaderiaIdLabel.Text = "Mercaderia:";
            // 
            // cantidadLabel1
            // 
            cantidadLabel1.AutoSize = true;
            cantidadLabel1.BackColor = System.Drawing.Color.Transparent;
            cantidadLabel1.Location = new System.Drawing.Point(182, 191);
            cantidadLabel1.Name = "cantidadLabel1";
            cantidadLabel1.Size = new System.Drawing.Size(52, 13);
            cantidadLabel1.TabIndex = 6;
            cantidadLabel1.Text = "Cantidad:";
            // 
            // costoLabel
            // 
            costoLabel.AutoSize = true;
            costoLabel.BackColor = System.Drawing.Color.Transparent;
            costoLabel.Location = new System.Drawing.Point(182, 217);
            costoLabel.Name = "costoLabel";
            costoLabel.Size = new System.Drawing.Size(37, 13);
            costoLabel.TabIndex = 8;
            costoLabel.Text = "Costo:";
            // 
            // unidadMedidaLabel
            // 
            unidadMedidaLabel.AutoSize = true;
            unidadMedidaLabel.BackColor = System.Drawing.Color.Transparent;
            unidadMedidaLabel.Location = new System.Drawing.Point(182, 164);
            unidadMedidaLabel.Name = "unidadMedidaLabel";
            unidadMedidaLabel.Size = new System.Drawing.Size(82, 13);
            unidadMedidaLabel.TabIndex = 10;
            unidadMedidaLabel.Text = "Unidad Medida:";
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
            this.BaseFormHeaderGroup.TabIndex = 17;
            this.BaseFormHeaderGroup.ValuesPrimary.Heading = "Mantenimiento Ajuste de Inventario Detalle";
            this.BaseFormHeaderGroup.ValuesPrimary.Image = null;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(cantidadLabel1);
            this.kryptonPanel1.Controls.Add(this.cantidadTextBox1);
            this.kryptonPanel1.Controls.Add(costoLabel);
            this.kryptonPanel1.Controls.Add(this.costoTextBox);
            this.kryptonPanel1.Controls.Add(unidadMedidaLabel);
            this.kryptonPanel1.Controls.Add(this.unidadMedidaComboBox);
            this.kryptonPanel1.Controls.Add(this.mercaderiaTextBox);
            this.kryptonPanel1.Controls.Add(mercaderiaIdLabel);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(798, 395);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // cantidadTextBox1
            // 
            this.cantidadTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ajusteInventarioDetalleViewModelBindingSource, "Cantidad", true));
            this.cantidadTextBox1.Location = new System.Drawing.Point(277, 188);
            this.cantidadTextBox1.Name = "cantidadTextBox1";
            this.cantidadTextBox1.Size = new System.Drawing.Size(365, 20);
            this.cantidadTextBox1.TabIndex = 7;
            // 
            // ajusteInventarioDetalleViewModelBindingSource
            // 
            this.ajusteInventarioDetalleViewModelBindingSource.DataSource = typeof(AdmCostoProduccion.Common.ViewModels.Inventario.AjusteInventarioDetalleViewModel);
            // 
            // costoTextBox
            // 
            this.costoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ajusteInventarioDetalleViewModelBindingSource, "Costo", true));
            this.costoTextBox.Location = new System.Drawing.Point(277, 214);
            this.costoTextBox.Name = "costoTextBox";
            this.costoTextBox.Size = new System.Drawing.Size(365, 20);
            this.costoTextBox.TabIndex = 9;
            // 
            // unidadMedidaComboBox
            // 
            this.unidadMedidaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ajusteInventarioDetalleViewModelBindingSource, "UnidadMedida", true));
            this.unidadMedidaComboBox.DataSource = this.unidadMedidaViewModelBindingSource;
            this.unidadMedidaComboBox.DisplayMember = "Nombre";
            this.unidadMedidaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unidadMedidaComboBox.FormattingEnabled = true;
            this.unidadMedidaComboBox.Location = new System.Drawing.Point(277, 161);
            this.unidadMedidaComboBox.Name = "unidadMedidaComboBox";
            this.unidadMedidaComboBox.Size = new System.Drawing.Size(365, 21);
            this.unidadMedidaComboBox.TabIndex = 11;
            this.unidadMedidaComboBox.ValueMember = "UnidadMedidaId";
            // 
            // mercaderiaTextBox
            // 
            this.mercaderiaTextBox.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.BuscarMercaderiaButton});
            this.mercaderiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ajusteInventarioDetalleViewModelBindingSource, "NombreMercaderia", true));
            this.mercaderiaTextBox.Location = new System.Drawing.Point(277, 132);
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
            this.BaseFormToolStrip.TabIndex = 16;
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
            // unidadMedidaViewModelBindingSource
            // 
            this.unidadMedidaViewModelBindingSource.DataSource = typeof(AdmCostoProduccion.Common.ViewModels.Inventario.UnidadMedidaViewModel);
            // 
            // MntAjusteInventarioDetalleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BaseFormHeaderGroup);
            this.Controls.Add(this.BaseFormToolStrip);
            this.Name = "MntAjusteInventarioDetalleForm";
            this.Text = "Mantenimiento Ajuste de Inventario Detalle";
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup.Panel)).EndInit();
            this.BaseFormHeaderGroup.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup)).EndInit();
            this.BaseFormHeaderGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ajusteInventarioDetalleViewModelBindingSource)).EndInit();
            this.BaseFormToolStrip.ResumeLayout(false);
            this.BaseFormToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unidadMedidaViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup BaseFormHeaderGroup;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox mercaderiaTextBox;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny BuscarMercaderiaButton;
        protected System.Windows.Forms.ToolStrip BaseFormToolStrip;
        private System.Windows.Forms.ToolStripButton GrabarButton;
        private System.Windows.Forms.ToolStripButton CancelarButton;
        private System.Windows.Forms.TextBox cantidadTextBox1;
        private System.Windows.Forms.BindingSource ajusteInventarioDetalleViewModelBindingSource;
        private System.Windows.Forms.TextBox costoTextBox;
        private System.Windows.Forms.ComboBox unidadMedidaComboBox;
        private System.Windows.Forms.BindingSource unidadMedidaViewModelBindingSource;
    }
}