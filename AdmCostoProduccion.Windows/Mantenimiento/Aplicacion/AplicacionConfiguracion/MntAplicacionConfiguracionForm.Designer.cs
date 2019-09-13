namespace AdmCostoProduccion.Windows.Mantenimiento.Aplicacion.AplicacionConfiguracion
{
    partial class MntAplicacionConfiguracionForm
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
            System.Windows.Forms.Label despachoGeneraMovimientoLabel;
            System.Windows.Forms.Label ordenProduccionGeneraMovimientoLabel;
            System.Windows.Forms.Label ordenProduccionGeneraMovimientoInsumosLabel;
            System.Windows.Forms.Label recepcionGeneraMovimientoLabel;
            this.BaseFormHeaderGroup = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.despachoGeneraMovimientoCheckBox = new System.Windows.Forms.CheckBox();
            this.aplicacionConfiguracionViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordenProduccionGeneraMovimientoCheckBox = new System.Windows.Forms.CheckBox();
            this.ordenProduccionGeneraMovimientoInsumosCheckBox = new System.Windows.Forms.CheckBox();
            this.recepcionGeneraMovimientoCheckBox = new System.Windows.Forms.CheckBox();
            this.BaseFormToolStrip = new System.Windows.Forms.ToolStrip();
            this.GrabarButton = new System.Windows.Forms.ToolStripButton();
            this.CancelarButton = new System.Windows.Forms.ToolStripButton();
            despachoGeneraMovimientoLabel = new System.Windows.Forms.Label();
            ordenProduccionGeneraMovimientoLabel = new System.Windows.Forms.Label();
            ordenProduccionGeneraMovimientoInsumosLabel = new System.Windows.Forms.Label();
            recepcionGeneraMovimientoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup.Panel)).BeginInit();
            this.BaseFormHeaderGroup.Panel.SuspendLayout();
            this.BaseFormHeaderGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aplicacionConfiguracionViewModelBindingSource)).BeginInit();
            this.BaseFormToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // despachoGeneraMovimientoLabel
            // 
            despachoGeneraMovimientoLabel.AutoSize = true;
            despachoGeneraMovimientoLabel.BackColor = System.Drawing.Color.Transparent;
            despachoGeneraMovimientoLabel.Location = new System.Drawing.Point(243, 144);
            despachoGeneraMovimientoLabel.Name = "despachoGeneraMovimientoLabel";
            despachoGeneraMovimientoLabel.Size = new System.Drawing.Size(128, 13);
            despachoGeneraMovimientoLabel.TabIndex = 0;
            despachoGeneraMovimientoLabel.Text = "Venta Genera Despacho:";
            // 
            // ordenProduccionGeneraMovimientoLabel
            // 
            ordenProduccionGeneraMovimientoLabel.AutoSize = true;
            ordenProduccionGeneraMovimientoLabel.BackColor = System.Drawing.Color.Transparent;
            ordenProduccionGeneraMovimientoLabel.Location = new System.Drawing.Point(243, 174);
            ordenProduccionGeneraMovimientoLabel.Name = "ordenProduccionGeneraMovimientoLabel";
            ordenProduccionGeneraMovimientoLabel.Size = new System.Drawing.Size(191, 13);
            ordenProduccionGeneraMovimientoLabel.TabIndex = 2;
            ordenProduccionGeneraMovimientoLabel.Text = "Orden Produccion Genera Movimiento:";
            // 
            // ordenProduccionGeneraMovimientoInsumosLabel
            // 
            ordenProduccionGeneraMovimientoInsumosLabel.AutoSize = true;
            ordenProduccionGeneraMovimientoInsumosLabel.BackColor = System.Drawing.Color.Transparent;
            ordenProduccionGeneraMovimientoInsumosLabel.Location = new System.Drawing.Point(243, 204);
            ordenProduccionGeneraMovimientoInsumosLabel.Name = "ordenProduccionGeneraMovimientoInsumosLabel";
            ordenProduccionGeneraMovimientoInsumosLabel.Size = new System.Drawing.Size(233, 13);
            ordenProduccionGeneraMovimientoInsumosLabel.TabIndex = 4;
            ordenProduccionGeneraMovimientoInsumosLabel.Text = "Orden Produccion Genera Movimiento Insumos:";
            // 
            // recepcionGeneraMovimientoLabel
            // 
            recepcionGeneraMovimientoLabel.AutoSize = true;
            recepcionGeneraMovimientoLabel.BackColor = System.Drawing.Color.Transparent;
            recepcionGeneraMovimientoLabel.Location = new System.Drawing.Point(243, 114);
            recepcionGeneraMovimientoLabel.Name = "recepcionGeneraMovimientoLabel";
            recepcionGeneraMovimientoLabel.Size = new System.Drawing.Size(139, 13);
            recepcionGeneraMovimientoLabel.TabIndex = 6;
            recepcionGeneraMovimientoLabel.Text = "Compra Genera Recepción:";
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
            this.BaseFormHeaderGroup.TabIndex = 23;
            this.BaseFormHeaderGroup.ValuesPrimary.Heading = "Configuracion de Aplicación";
            this.BaseFormHeaderGroup.ValuesPrimary.Image = null;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(despachoGeneraMovimientoLabel);
            this.kryptonPanel1.Controls.Add(this.despachoGeneraMovimientoCheckBox);
            this.kryptonPanel1.Controls.Add(ordenProduccionGeneraMovimientoLabel);
            this.kryptonPanel1.Controls.Add(this.ordenProduccionGeneraMovimientoCheckBox);
            this.kryptonPanel1.Controls.Add(ordenProduccionGeneraMovimientoInsumosLabel);
            this.kryptonPanel1.Controls.Add(this.ordenProduccionGeneraMovimientoInsumosCheckBox);
            this.kryptonPanel1.Controls.Add(recepcionGeneraMovimientoLabel);
            this.kryptonPanel1.Controls.Add(this.recepcionGeneraMovimientoCheckBox);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(798, 395);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // despachoGeneraMovimientoCheckBox
            // 
            this.despachoGeneraMovimientoCheckBox.AutoSize = true;
            this.despachoGeneraMovimientoCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.despachoGeneraMovimientoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.aplicacionConfiguracionViewModelBindingSource, "DespachoGeneraMovimiento", true));
            this.despachoGeneraMovimientoCheckBox.Location = new System.Drawing.Point(482, 144);
            this.despachoGeneraMovimientoCheckBox.Name = "despachoGeneraMovimientoCheckBox";
            this.despachoGeneraMovimientoCheckBox.Size = new System.Drawing.Size(15, 14);
            this.despachoGeneraMovimientoCheckBox.TabIndex = 1;
            this.despachoGeneraMovimientoCheckBox.UseVisualStyleBackColor = false;
            // 
            // aplicacionConfiguracionViewModelBindingSource
            // 
            this.aplicacionConfiguracionViewModelBindingSource.DataSource = typeof(AdmCostoProduccion.Common.ViewModels.Aplicacion.AplicacionConfiguracionViewModel);
            // 
            // ordenProduccionGeneraMovimientoCheckBox
            // 
            this.ordenProduccionGeneraMovimientoCheckBox.AutoSize = true;
            this.ordenProduccionGeneraMovimientoCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.ordenProduccionGeneraMovimientoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.aplicacionConfiguracionViewModelBindingSource, "OrdenProduccionGeneraMovimiento", true));
            this.ordenProduccionGeneraMovimientoCheckBox.Location = new System.Drawing.Point(482, 174);
            this.ordenProduccionGeneraMovimientoCheckBox.Name = "ordenProduccionGeneraMovimientoCheckBox";
            this.ordenProduccionGeneraMovimientoCheckBox.Size = new System.Drawing.Size(15, 14);
            this.ordenProduccionGeneraMovimientoCheckBox.TabIndex = 3;
            this.ordenProduccionGeneraMovimientoCheckBox.UseVisualStyleBackColor = false;
            // 
            // ordenProduccionGeneraMovimientoInsumosCheckBox
            // 
            this.ordenProduccionGeneraMovimientoInsumosCheckBox.AutoSize = true;
            this.ordenProduccionGeneraMovimientoInsumosCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.ordenProduccionGeneraMovimientoInsumosCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.aplicacionConfiguracionViewModelBindingSource, "OrdenProduccionGeneraMovimientoInsumos", true));
            this.ordenProduccionGeneraMovimientoInsumosCheckBox.Location = new System.Drawing.Point(482, 204);
            this.ordenProduccionGeneraMovimientoInsumosCheckBox.Name = "ordenProduccionGeneraMovimientoInsumosCheckBox";
            this.ordenProduccionGeneraMovimientoInsumosCheckBox.Size = new System.Drawing.Size(15, 14);
            this.ordenProduccionGeneraMovimientoInsumosCheckBox.TabIndex = 5;
            this.ordenProduccionGeneraMovimientoInsumosCheckBox.UseVisualStyleBackColor = false;
            // 
            // recepcionGeneraMovimientoCheckBox
            // 
            this.recepcionGeneraMovimientoCheckBox.AutoSize = true;
            this.recepcionGeneraMovimientoCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.recepcionGeneraMovimientoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.aplicacionConfiguracionViewModelBindingSource, "RecepcionGeneraMovimiento", true));
            this.recepcionGeneraMovimientoCheckBox.Location = new System.Drawing.Point(482, 114);
            this.recepcionGeneraMovimientoCheckBox.Name = "recepcionGeneraMovimientoCheckBox";
            this.recepcionGeneraMovimientoCheckBox.Size = new System.Drawing.Size(15, 14);
            this.recepcionGeneraMovimientoCheckBox.TabIndex = 7;
            this.recepcionGeneraMovimientoCheckBox.UseVisualStyleBackColor = false;
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
            this.BaseFormToolStrip.TabIndex = 22;
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
            // MntAplicacionConfiguracionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BaseFormHeaderGroup);
            this.Controls.Add(this.BaseFormToolStrip);
            this.Name = "MntAplicacionConfiguracionForm";
            this.Text = "Configuracion de Aplicación";
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup.Panel)).EndInit();
            this.BaseFormHeaderGroup.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup)).EndInit();
            this.BaseFormHeaderGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aplicacionConfiguracionViewModelBindingSource)).EndInit();
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
        private System.Windows.Forms.CheckBox despachoGeneraMovimientoCheckBox;
        private System.Windows.Forms.BindingSource aplicacionConfiguracionViewModelBindingSource;
        private System.Windows.Forms.CheckBox ordenProduccionGeneraMovimientoCheckBox;
        private System.Windows.Forms.CheckBox ordenProduccionGeneraMovimientoInsumosCheckBox;
        private System.Windows.Forms.CheckBox recepcionGeneraMovimientoCheckBox;
    }
}