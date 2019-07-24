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
            this.MaestrosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CentroLogisticoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PlantaFabricacionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AlmacenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MntInventarioMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UnidadMedidaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TipoMercaderiaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MercaderíaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TipoMovimientoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TipoRecepcionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TipoDespachoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MntProducciónMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProcedimientoProduccionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MntContabilidadMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.métodoValorizaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.distribuciónValorizaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónValorizaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProcesosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InventarioMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RecepcionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DespachoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CompraVentaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProducciónMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenDeProducciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contabilidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.costoOrdenProducciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.MainFormKryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.MainFormKryptonDockableNavigator = new ComponentFactory.Krypton.Docking.KryptonDockableNavigator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.SalirButton = new System.Windows.Forms.ToolStripButton();
            this.SalirMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.ProcesosMenuItem,
            this.consultasToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.PrincipalMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.PrincipalMenuStrip.MdiWindowListItem = this.MantenimientoMenuItem;
            this.PrincipalMenuStrip.Name = "PrincipalMenuStrip";
            this.PrincipalMenuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.PrincipalMenuStrip.Size = new System.Drawing.Size(1149, 28);
            this.PrincipalMenuStrip.TabIndex = 4;
            this.PrincipalMenuStrip.Text = "menuStrip1";
            // 
            // MantenimientoMenuItem
            // 
            this.MantenimientoMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MaestrosMenuItem,
            this.MntInventarioMenuItem,
            this.MntProducciónMenuItem,
            this.MntContabilidadMenuItem,
            this.SalirMenuItem});
            this.MantenimientoMenuItem.Name = "MantenimientoMenuItem";
            this.MantenimientoMenuItem.Size = new System.Drawing.Size(124, 24);
            this.MantenimientoMenuItem.Text = "Mantenimiento";
            // 
            // MaestrosMenuItem
            // 
            this.MaestrosMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CentroLogisticoMenuItem,
            this.PlantaFabricacionMenuItem,
            this.AlmacenMenuItem});
            this.MaestrosMenuItem.Name = "MaestrosMenuItem";
            this.MaestrosMenuItem.Size = new System.Drawing.Size(178, 26);
            this.MaestrosMenuItem.Text = "Maestros";
            // 
            // CentroLogisticoMenuItem
            // 
            this.CentroLogisticoMenuItem.Name = "CentroLogisticoMenuItem";
            this.CentroLogisticoMenuItem.Size = new System.Drawing.Size(233, 26);
            this.CentroLogisticoMenuItem.Text = "Centro Logistico";
            this.CentroLogisticoMenuItem.Click += new System.EventHandler(this.CentroLogisticoMenuItem_Click);
            // 
            // PlantaFabricacionMenuItem
            // 
            this.PlantaFabricacionMenuItem.Name = "PlantaFabricacionMenuItem";
            this.PlantaFabricacionMenuItem.Size = new System.Drawing.Size(233, 26);
            this.PlantaFabricacionMenuItem.Text = "Planta de Fabricación";
            this.PlantaFabricacionMenuItem.Click += new System.EventHandler(this.PlantaFabricacionMenuItem_Click);
            // 
            // AlmacenMenuItem
            // 
            this.AlmacenMenuItem.Name = "AlmacenMenuItem";
            this.AlmacenMenuItem.Size = new System.Drawing.Size(233, 26);
            this.AlmacenMenuItem.Text = "Almacén";
            this.AlmacenMenuItem.Click += new System.EventHandler(this.AlmacenMenuItem_Click);
            // 
            // MntInventarioMenuItem
            // 
            this.MntInventarioMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UnidadMedidaMenuItem,
            this.TipoMercaderiaMenuItem,
            this.MercaderíaMenuItem,
            this.TipoMovimientoMenuItem,
            this.TipoRecepcionMenuItem,
            this.TipoDespachoMenuItem});
            this.MntInventarioMenuItem.Name = "MntInventarioMenuItem";
            this.MntInventarioMenuItem.Size = new System.Drawing.Size(178, 26);
            this.MntInventarioMenuItem.Text = "Inventario";
            // 
            // UnidadMedidaMenuItem
            // 
            this.UnidadMedidaMenuItem.Name = "UnidadMedidaMenuItem";
            this.UnidadMedidaMenuItem.Size = new System.Drawing.Size(216, 26);
            this.UnidadMedidaMenuItem.Text = "Unidad de Medida";
            this.UnidadMedidaMenuItem.Click += new System.EventHandler(this.UnidadMedidaMenuItem_Click);
            // 
            // TipoMercaderiaMenuItem
            // 
            this.TipoMercaderiaMenuItem.Name = "TipoMercaderiaMenuItem";
            this.TipoMercaderiaMenuItem.Size = new System.Drawing.Size(216, 26);
            this.TipoMercaderiaMenuItem.Text = "Tipo Mercadería";
            this.TipoMercaderiaMenuItem.Click += new System.EventHandler(this.TipoMercaderiaMenuItem_Click);
            // 
            // MercaderíaMenuItem
            // 
            this.MercaderíaMenuItem.Name = "MercaderíaMenuItem";
            this.MercaderíaMenuItem.Size = new System.Drawing.Size(216, 26);
            this.MercaderíaMenuItem.Text = "Mercadería";
            this.MercaderíaMenuItem.Click += new System.EventHandler(this.MercaderíaMenuItem_Click);
            // 
            // TipoMovimientoMenuItem
            // 
            this.TipoMovimientoMenuItem.Name = "TipoMovimientoMenuItem";
            this.TipoMovimientoMenuItem.Size = new System.Drawing.Size(216, 26);
            this.TipoMovimientoMenuItem.Text = "Tipo Movimiento";
            this.TipoMovimientoMenuItem.Click += new System.EventHandler(this.TipoMovimientoMenuItem_Click);
            // 
            // TipoRecepcionMenuItem
            // 
            this.TipoRecepcionMenuItem.Name = "TipoRecepcionMenuItem";
            this.TipoRecepcionMenuItem.Size = new System.Drawing.Size(216, 26);
            this.TipoRecepcionMenuItem.Text = "Tipo Recepción";
            this.TipoRecepcionMenuItem.Click += new System.EventHandler(this.TipoRecepcionMenuItem_Click);
            // 
            // TipoDespachoMenuItem
            // 
            this.TipoDespachoMenuItem.Name = "TipoDespachoMenuItem";
            this.TipoDespachoMenuItem.Size = new System.Drawing.Size(216, 26);
            this.TipoDespachoMenuItem.Text = "Tipo Despacho";
            this.TipoDespachoMenuItem.Click += new System.EventHandler(this.TipoDespachoMenuItem_Click);
            // 
            // MntProducciónMenuItem
            // 
            this.MntProducciónMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProcedimientoProduccionMenuItem});
            this.MntProducciónMenuItem.Name = "MntProducciónMenuItem";
            this.MntProducciónMenuItem.Size = new System.Drawing.Size(178, 26);
            this.MntProducciónMenuItem.Text = "Producción";
            // 
            // ProcedimientoProduccionMenuItem
            // 
            this.ProcedimientoProduccionMenuItem.Name = "ProcedimientoProduccionMenuItem";
            this.ProcedimientoProduccionMenuItem.Size = new System.Drawing.Size(288, 26);
            this.ProcedimientoProduccionMenuItem.Text = "Procedimiento de Producción";
            this.ProcedimientoProduccionMenuItem.Click += new System.EventHandler(this.ProcedimientoProduccionMenuItem_Click);
            // 
            // MntContabilidadMenuItem
            // 
            this.MntContabilidadMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.métodoValorizaciónToolStripMenuItem,
            this.distribuciónValorizaciónToolStripMenuItem,
            this.configuraciónValorizaciónToolStripMenuItem});
            this.MntContabilidadMenuItem.Name = "MntContabilidadMenuItem";
            this.MntContabilidadMenuItem.Size = new System.Drawing.Size(178, 26);
            this.MntContabilidadMenuItem.Text = "Contabilidad";
            // 
            // métodoValorizaciónToolStripMenuItem
            // 
            this.métodoValorizaciónToolStripMenuItem.Name = "métodoValorizaciónToolStripMenuItem";
            this.métodoValorizaciónToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.métodoValorizaciónToolStripMenuItem.Text = "Método Valorización";
            // 
            // distribuciónValorizaciónToolStripMenuItem
            // 
            this.distribuciónValorizaciónToolStripMenuItem.Name = "distribuciónValorizaciónToolStripMenuItem";
            this.distribuciónValorizaciónToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.distribuciónValorizaciónToolStripMenuItem.Text = "Distribución Valorización";
            // 
            // configuraciónValorizaciónToolStripMenuItem
            // 
            this.configuraciónValorizaciónToolStripMenuItem.Name = "configuraciónValorizaciónToolStripMenuItem";
            this.configuraciónValorizaciónToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.configuraciónValorizaciónToolStripMenuItem.Text = "Configuración Valorización";
            // 
            // ProcesosMenuItem
            // 
            this.ProcesosMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InventarioMenuItem,
            this.CompraVentaMenuItem,
            this.ProducciónMenuItem,
            this.contabilidadToolStripMenuItem});
            this.ProcesosMenuItem.Name = "ProcesosMenuItem";
            this.ProcesosMenuItem.Size = new System.Drawing.Size(81, 24);
            this.ProcesosMenuItem.Text = "Procesos";
            // 
            // InventarioMenuItem
            // 
            this.InventarioMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RecepcionMenuItem,
            this.DespachoMenuItem});
            this.InventarioMenuItem.Name = "InventarioMenuItem";
            this.InventarioMenuItem.Size = new System.Drawing.Size(224, 26);
            this.InventarioMenuItem.Text = "Inventario";
            // 
            // RecepcionMenuItem
            // 
            this.RecepcionMenuItem.Name = "RecepcionMenuItem";
            this.RecepcionMenuItem.Size = new System.Drawing.Size(224, 26);
            this.RecepcionMenuItem.Text = "Recepción";
            this.RecepcionMenuItem.Click += new System.EventHandler(this.RecepcionMenuItem_Click);
            // 
            // DespachoMenuItem
            // 
            this.DespachoMenuItem.Name = "DespachoMenuItem";
            this.DespachoMenuItem.Size = new System.Drawing.Size(224, 26);
            this.DespachoMenuItem.Text = "Despacho";
            this.DespachoMenuItem.Click += new System.EventHandler(this.DespachoMenuItem_Click);
            // 
            // CompraVentaMenuItem
            // 
            this.CompraVentaMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comprasToolStripMenuItem,
            this.ventasToolStripMenuItem});
            this.CompraVentaMenuItem.Name = "CompraVentaMenuItem";
            this.CompraVentaMenuItem.Size = new System.Drawing.Size(224, 26);
            this.CompraVentaMenuItem.Text = "Compra/Venta";
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.comprasToolStripMenuItem.Text = "Compra";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.ventasToolStripMenuItem.Text = "Venta";
            // 
            // ProducciónMenuItem
            // 
            this.ProducciónMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenDeProducciónToolStripMenuItem});
            this.ProducciónMenuItem.Name = "ProducciónMenuItem";
            this.ProducciónMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ProducciónMenuItem.Text = "Producción";
            // 
            // ordenDeProducciónToolStripMenuItem
            // 
            this.ordenDeProducciónToolStripMenuItem.Name = "ordenDeProducciónToolStripMenuItem";
            this.ordenDeProducciónToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.ordenDeProducciónToolStripMenuItem.Text = "Orden de Producción";
            // 
            // contabilidadToolStripMenuItem
            // 
            this.contabilidadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.costoOrdenProducciónToolStripMenuItem});
            this.contabilidadToolStripMenuItem.Name = "contabilidadToolStripMenuItem";
            this.contabilidadToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.contabilidadToolStripMenuItem.Text = "Contabilidad";
            // 
            // costoOrdenProducciónToolStripMenuItem
            // 
            this.costoOrdenProducciónToolStripMenuItem.Name = "costoOrdenProducciónToolStripMenuItem";
            this.costoOrdenProducciónToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.costoOrdenProducciónToolStripMenuItem.Text = "Costo Orden Producción";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SalirButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.toolStrip1.Size = new System.Drawing.Size(1149, 29);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
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
            this.MainFormKryptonDockableNavigator.Location = new System.Drawing.Point(0, 57);
            this.MainFormKryptonDockableNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainFormKryptonDockableNavigator.Name = "MainFormKryptonDockableNavigator";
            this.MainFormKryptonDockableNavigator.Size = new System.Drawing.Size(1149, 585);
            this.MainFormKryptonDockableNavigator.TabIndex = 9;
            this.MainFormKryptonDockableNavigator.Text = "kryptonDockableNavigator1";
            this.MainFormKryptonDockableNavigator.Visible = false;
            this.MainFormKryptonDockableNavigator.SelectedPageChanged += new System.EventHandler(this.MainFormKryptonDockableNavigator_SelectedPageChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 620);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(1149, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // SalirButton
            // 
            this.SalirButton.Image = global::AdmCostoProduccion.Windows.Properties.Resources.outbox_16x16;
            this.SalirButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(62, 24);
            this.SalirButton.Text = "Salir";
            this.SalirButton.Click += new System.EventHandler(this.SalirButton_Click);
            // 
            // SalirMenuItem
            // 
            this.SalirMenuItem.Image = global::AdmCostoProduccion.Windows.Properties.Resources.outbox_16x16;
            this.SalirMenuItem.Name = "SalirMenuItem";
            this.SalirMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.SalirMenuItem.Size = new System.Drawing.Size(178, 26);
            this.SalirMenuItem.Text = "Salir";
            this.SalirMenuItem.Click += new System.EventHandler(this.SalirMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 642);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MainFormKryptonDockableNavigator);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.PrincipalMenuStrip);
            this.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Calendar;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.PrincipalMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.ToolStripMenuItem MercaderíaMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TipoMercaderiaMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CompraVentaMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProducciónMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProcedimientoProduccionMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenDeProducciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InventarioMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RecepcionMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DespachoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MntInventarioMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProcesosMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MntProducciónMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TipoRecepcionMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TipoDespachoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TipoMovimientoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MntContabilidadMenuItem;
        private System.Windows.Forms.ToolStripMenuItem métodoValorizaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem distribuciónValorizaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónValorizaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contabilidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem costoOrdenProducciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UnidadMedidaMenuItem;
    }
}

