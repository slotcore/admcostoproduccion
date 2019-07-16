namespace AdmCostoProduccion.Windows
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainTabForm = new System.Windows.Forms.TabControl();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.MantenimientoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MaestrosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CentroLogisticoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AlmacenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabForm
            // 
            this.MainTabForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainTabForm.Location = new System.Drawing.Point(0, 28);
            this.MainTabForm.Margin = new System.Windows.Forms.Padding(4);
            this.MainTabForm.Name = "MainTabForm";
            this.MainTabForm.SelectedIndex = 0;
            this.MainTabForm.Size = new System.Drawing.Size(800, 30);
            this.MainTabForm.TabIndex = 3;
            this.MainTabForm.Visible = false;
            this.MainTabForm.SelectedIndexChanged += new System.EventHandler(this.MainTabForm_SelectedIndexChanged);
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MantenimientoMenuItem,
            this.MaestrosMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.MdiWindowListItem = this.MantenimientoMenuItem;
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.MainMenuStrip.Size = new System.Drawing.Size(800, 28);
            this.MainMenuStrip.TabIndex = 4;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // MantenimientoMenuItem
            // 
            this.MantenimientoMenuItem.Name = "MantenimientoMenuItem";
            this.MantenimientoMenuItem.Size = new System.Drawing.Size(124, 24);
            this.MantenimientoMenuItem.Text = "Mantenimiento";
            // 
            // MaestrosMenuItem
            // 
            this.MaestrosMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CentroLogisticoMenuItem,
            this.AlmacenMenuItem});
            this.MaestrosMenuItem.Name = "MaestrosMenuItem";
            this.MaestrosMenuItem.Size = new System.Drawing.Size(83, 24);
            this.MaestrosMenuItem.Text = "Maestros";
            // 
            // CentroLogisticoMenuItem
            // 
            this.CentroLogisticoMenuItem.Name = "CentroLogisticoMenuItem";
            this.CentroLogisticoMenuItem.Size = new System.Drawing.Size(224, 26);
            this.CentroLogisticoMenuItem.Text = "Centro Logistico";
            this.CentroLogisticoMenuItem.Click += new System.EventHandler(this.CentroLogisticoMenuItem_Click);
            // 
            // AlmacenMenuItem
            // 
            this.AlmacenMenuItem.Name = "AlmacenMenuItem";
            this.AlmacenMenuItem.Size = new System.Drawing.Size(224, 26);
            this.AlmacenMenuItem.Text = "Almacén";
            this.AlmacenMenuItem.Click += new System.EventHandler(this.AlmacenMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainTabForm);
            this.Controls.Add(this.MainMenuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MainMenuStrip;
            this.Name = "MainForm";
            this.Text = "Administración de Costo de Producción";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MdiChildActivate += new System.EventHandler(this.MainForm_MdiChildActivate);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabForm;
        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MaestrosMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CentroLogisticoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AlmacenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MantenimientoMenuItem;
    }
}

