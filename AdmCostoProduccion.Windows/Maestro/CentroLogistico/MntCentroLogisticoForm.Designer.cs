namespace AdmCostoProduccion.Windows.Maestro.CentroLogistico
{
    partial class MntCentroLogisticoForm
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
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label nombreLabel;
            this.BaseFormToolStrip = new System.Windows.Forms.ToolStrip();
            this.GrabarButton = new System.Windows.Forms.ToolStripButton();
            this.CancelarButton = new System.Windows.Forms.ToolStripButton();
            this.BaseFormHeaderGroup = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.centroLogisticoViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            codigoLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            this.BaseFormToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup.Panel)).BeginInit();
            this.BaseFormHeaderGroup.Panel.SuspendLayout();
            this.BaseFormHeaderGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.centroLogisticoViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.BackColor = System.Drawing.Color.Transparent;
            codigoLabel.Location = new System.Drawing.Point(246, 193);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(56, 17);
            codigoLabel.TabIndex = 0;
            codigoLabel.Text = "Codigo:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.BackColor = System.Drawing.Color.Transparent;
            descripcionLabel.Location = new System.Drawing.Point(246, 221);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(86, 17);
            descripcionLabel.TabIndex = 2;
            descripcionLabel.Text = "Descripcion:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.BackColor = System.Drawing.Color.Transparent;
            nombreLabel.Location = new System.Drawing.Point(246, 249);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(62, 17);
            nombreLabel.TabIndex = 4;
            nombreLabel.Text = "Nombre:";
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
            this.BaseFormToolStrip.Size = new System.Drawing.Size(1080, 31);
            this.BaseFormToolStrip.TabIndex = 2;
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
            // 
            // BaseFormHeaderGroup
            // 
            this.BaseFormHeaderGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BaseFormHeaderGroup.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Calendar;
            this.BaseFormHeaderGroup.HeaderStyleSecondary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Form;
            this.BaseFormHeaderGroup.HeaderVisibleSecondary = false;
            this.BaseFormHeaderGroup.Location = new System.Drawing.Point(0, 31);
            this.BaseFormHeaderGroup.Name = "BaseFormHeaderGroup";
            // 
            // BaseFormHeaderGroup.Panel
            // 
            this.BaseFormHeaderGroup.Panel.Controls.Add(this.kryptonPanel1);
            this.BaseFormHeaderGroup.Size = new System.Drawing.Size(1080, 600);
            this.BaseFormHeaderGroup.StateNormal.HeaderPrimary.Border.Color1 = System.Drawing.SystemColors.ControlDarkDark;
            this.BaseFormHeaderGroup.StateNormal.HeaderPrimary.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.BaseFormHeaderGroup.StateNormal.HeaderPrimary.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.BaseFormHeaderGroup.StateNormal.HeaderPrimary.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.BaseFormHeaderGroup.StateNormal.HeaderPrimary.Border.Width = 1;
            this.BaseFormHeaderGroup.TabIndex = 3;
            this.BaseFormHeaderGroup.ValuesPrimary.Heading = "Centro Logístico";
            this.BaseFormHeaderGroup.ValuesPrimary.Image = null;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(codigoLabel);
            this.kryptonPanel1.Controls.Add(this.codigoTextBox);
            this.kryptonPanel1.Controls.Add(descripcionLabel);
            this.kryptonPanel1.Controls.Add(this.descripcionTextBox);
            this.kryptonPanel1.Controls.Add(nombreLabel);
            this.kryptonPanel1.Controls.Add(this.nombreTextBox);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1078, 572);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.centroLogisticoViewModelBindingSource, "Codigo", true));
            this.codigoTextBox.Location = new System.Drawing.Point(338, 190);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(461, 22);
            this.codigoTextBox.TabIndex = 1;
            // 
            // centroLogisticoViewModelBindingSource
            // 
            this.centroLogisticoViewModelBindingSource.DataSource = typeof(AdmCostoProduccion.Common.ViewModels.Maestro.CentroLogisticoViewModel);
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.centroLogisticoViewModelBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(338, 218);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(461, 22);
            this.descripcionTextBox.TabIndex = 3;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.centroLogisticoViewModelBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(338, 246);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(461, 22);
            this.nombreTextBox.TabIndex = 5;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 609);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(1080, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MntCentroLogisticoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 631);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.BaseFormHeaderGroup);
            this.Controls.Add(this.BaseFormToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MntCentroLogisticoForm";
            this.Text = "Mantenimiento Centro Logístico";
            this.BaseFormToolStrip.ResumeLayout(false);
            this.BaseFormToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup.Panel)).EndInit();
            this.BaseFormHeaderGroup.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormHeaderGroup)).EndInit();
            this.BaseFormHeaderGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.centroLogisticoViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.ToolStrip BaseFormToolStrip;
        private System.Windows.Forms.ToolStripButton GrabarButton;
        private System.Windows.Forms.ToolStripButton CancelarButton;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup BaseFormHeaderGroup;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.BindingSource centroLogisticoViewModelBindingSource;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
    }
}