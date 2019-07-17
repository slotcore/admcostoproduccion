namespace AdmCostoProduccion.Common.Forms
{
    partial class MainBaseForm
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
            this.MainKryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.MainBaseMenuStrip = new System.Windows.Forms.MenuStrip();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainBaseTabForm = new System.Windows.Forms.TabControl();
            this.MainBaseMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainKryptonManager
            // 
            this.MainKryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2010Silver;
            // 
            // MainBaseMenuStrip
            // 
            this.MainBaseMenuStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MainBaseMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainBaseMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem});
            this.MainBaseMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainBaseMenuStrip.Name = "MainBaseMenuStrip";
            this.MainBaseMenuStrip.Size = new System.Drawing.Size(800, 28);
            this.MainBaseMenuStrip.TabIndex = 0;
            this.MainBaseMenuStrip.Text = "menuStrip1";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // MainBaseTabForm
            // 
            this.MainBaseTabForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainBaseTabForm.Location = new System.Drawing.Point(0, 28);
            this.MainBaseTabForm.Margin = new System.Windows.Forms.Padding(4);
            this.MainBaseTabForm.Name = "MainBaseTabForm";
            this.MainBaseTabForm.SelectedIndex = 0;
            this.MainBaseTabForm.Size = new System.Drawing.Size(800, 30);
            this.MainBaseTabForm.TabIndex = 8;
            this.MainBaseTabForm.Visible = false;
            this.MainBaseTabForm.SelectedIndexChanged += new System.EventHandler(this.MainBaseTabForm_SelectedIndexChanged);
            // 
            // MainBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainBaseTabForm);
            this.Controls.Add(this.MainBaseMenuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MainBaseMenuStrip;
            this.Name = "MainBaseForm";
            this.Text = "MainBaseForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MdiChildActivate += new System.EventHandler(this.MainBaseForm_MdiChildActivate);
            this.MainBaseMenuStrip.ResumeLayout(false);
            this.MainBaseMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager MainKryptonManager;
        protected System.Windows.Forms.TabControl MainBaseTabForm;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        public System.Windows.Forms.MenuStrip MainBaseMenuStrip;
    }
}