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
            this.components = new System.ComponentModel.Container();
            this.PrincipalMenuStrip = new System.Windows.Forms.MenuStrip();
            this.MantenimientoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SalirMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MaestrosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CentroLogisticoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AlmacenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.SalirButton = new System.Windows.Forms.ToolStripButton();
            this.MainFormKryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.MainFormKryptonDockableNavigator = new ComponentFactory.Krypton.Docking.KryptonDockableNavigator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.PlantaFabricacionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrincipalMenuStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainFormKryptonDockableNavigator)).BeginInit();
            this.MainFormKryptonDockableNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrincipalMenuStrip
            // 
            this.PrincipalMenuStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PrincipalMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.PrincipalMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MantenimientoMenuItem,
            this.MaestrosMenuItem});
            this.PrincipalMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.PrincipalMenuStrip.MdiWindowListItem = this.MantenimientoMenuItem;
            this.PrincipalMenuStrip.Name = "PrincipalMenuStrip";
            this.PrincipalMenuStrip.Size = new System.Drawing.Size(862, 24);
            this.PrincipalMenuStrip.TabIndex = 4;
            this.PrincipalMenuStrip.Text = "menuStrip1";
            // 
            // MantenimientoMenuItem
            // 
            this.MantenimientoMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SalirMenuItem});
            this.MantenimientoMenuItem.Name = "MantenimientoMenuItem";
            this.MantenimientoMenuItem.Size = new System.Drawing.Size(101, 20);
            this.MantenimientoMenuItem.Text = "Mantenimiento";
            // 
            // SalirMenuItem
            // 
            this.SalirMenuItem.Image = global::AdmCostoProduccion.Windows.Properties.Resources.outbox_16x16;
            this.SalirMenuItem.Name = "SalirMenuItem";
            this.SalirMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.SalirMenuItem.Size = new System.Drawing.Size(146, 26);
            this.SalirMenuItem.Text = "Salir";
            this.SalirMenuItem.Click += new System.EventHandler(this.SalirMenuItem_Click);
            // 
            // MaestrosMenuItem
            // 
            this.MaestrosMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CentroLogisticoMenuItem,
            this.PlantaFabricacionMenuItem,
            this.AlmacenMenuItem});
            this.MaestrosMenuItem.Name = "MaestrosMenuItem";
            this.MaestrosMenuItem.Size = new System.Drawing.Size(67, 20);
            this.MaestrosMenuItem.Text = "Maestros";
            // 
            // CentroLogisticoMenuItem
            // 
            this.CentroLogisticoMenuItem.Name = "CentroLogisticoMenuItem";
            this.CentroLogisticoMenuItem.Size = new System.Drawing.Size(187, 22);
            this.CentroLogisticoMenuItem.Text = "Centro Logistico";
            this.CentroLogisticoMenuItem.Click += new System.EventHandler(this.CentroLogisticoMenuItem_Click);
            // 
            // AlmacenMenuItem
            // 
            this.AlmacenMenuItem.Name = "AlmacenMenuItem";
            this.AlmacenMenuItem.Size = new System.Drawing.Size(187, 22);
            this.AlmacenMenuItem.Text = "Almacén";
            this.AlmacenMenuItem.Click += new System.EventHandler(this.AlmacenMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SalirButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.toolStrip1.Size = new System.Drawing.Size(862, 29);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // SalirButton
            // 
            this.SalirButton.Image = global::AdmCostoProduccion.Windows.Properties.Resources.outbox_16x16;
            this.SalirButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(53, 24);
            this.SalirButton.Text = "Salir";
            this.SalirButton.Click += new System.EventHandler(this.SalirButton_Click);
            // 
            // MainFormKryptonManager
            // 
            this.MainFormKryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Silver;
            // 
            // MainFormKryptonDockableNavigator
            // 
            this.MainFormKryptonDockableNavigator.Bar.ItemSizing = ComponentFactory.Krypton.Navigator.BarItemSizing.Individual;
            this.MainFormKryptonDockableNavigator.Bar.TabStyle = ComponentFactory.Krypton.Toolkit.TabStyle.Dock;
            this.MainFormKryptonDockableNavigator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainFormKryptonDockableNavigator.Location = new System.Drawing.Point(0, 53);
            this.MainFormKryptonDockableNavigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MainFormKryptonDockableNavigator.Name = "MainFormKryptonDockableNavigator";
            this.MainFormKryptonDockableNavigator.Size = new System.Drawing.Size(862, 469);
            this.MainFormKryptonDockableNavigator.TabIndex = 9;
            this.MainFormKryptonDockableNavigator.Text = "kryptonDockableNavigator1";
            this.MainFormKryptonDockableNavigator.Visible = false;
            this.MainFormKryptonDockableNavigator.SelectedPageChanged += new System.EventHandler(this.MainFormKryptonDockableNavigator_SelectedPageChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 500);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(862, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // PlantaFabricacionMenuItem
            // 
            this.PlantaFabricacionMenuItem.Name = "PlantaFabricacionMenuItem";
            this.PlantaFabricacionMenuItem.Size = new System.Drawing.Size(187, 22);
            this.PlantaFabricacionMenuItem.Text = "Planta de Fabricación";
            this.PlantaFabricacionMenuItem.Click += new System.EventHandler(this.PlantaFabricacionMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 522);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MainFormKryptonDockableNavigator);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.PrincipalMenuStrip);
            this.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Calendar;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.PrincipalMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración de Costo de Producción";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MdiChildActivate += new System.EventHandler(this.MainForm_MdiChildActivate);
            this.PrincipalMenuStrip.ResumeLayout(false);
            this.PrincipalMenuStrip.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainFormKryptonDockableNavigator)).EndInit();
            this.MainFormKryptonDockableNavigator.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip PrincipalMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MaestrosMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CentroLogisticoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AlmacenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MantenimientoMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private ComponentFactory.Krypton.Toolkit.KryptonManager MainFormKryptonManager;
        private ComponentFactory.Krypton.Docking.KryptonDockableNavigator MainFormKryptonDockableNavigator;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripButton SalirButton;
        private System.Windows.Forms.ToolStripMenuItem SalirMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PlantaFabricacionMenuItem;
    }
}

