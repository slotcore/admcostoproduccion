namespace AdmCostoProduccion.Common.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_20190725_4 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.DespachoDetalles", new[] { "OrdenProduccionInsumoId" });
            DropIndex("dbo.DespachoDetalles", new[] { "VentaDetalleId" });
            DropIndex("dbo.RecepcionDetalles", new[] { "OrdenProduccionInsumoId" });
            DropIndex("dbo.RecepcionDetalles", new[] { "CompraDetalleId" });
            AlterColumn("dbo.DespachoDetalles", "OrdenProduccionInsumoId", c => c.Int());
            AlterColumn("dbo.DespachoDetalles", "VentaDetalleId", c => c.Int());
            AlterColumn("dbo.RecepcionDetalles", "OrdenProduccionInsumoId", c => c.Int());
            AlterColumn("dbo.RecepcionDetalles", "CompraDetalleId", c => c.Int());
            CreateIndex("dbo.DespachoDetalles", "OrdenProduccionInsumoId");
            CreateIndex("dbo.DespachoDetalles", "VentaDetalleId");
            CreateIndex("dbo.RecepcionDetalles", "OrdenProduccionInsumoId");
            CreateIndex("dbo.RecepcionDetalles", "CompraDetalleId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.RecepcionDetalles", new[] { "CompraDetalleId" });
            DropIndex("dbo.RecepcionDetalles", new[] { "OrdenProduccionInsumoId" });
            DropIndex("dbo.DespachoDetalles", new[] { "VentaDetalleId" });
            DropIndex("dbo.DespachoDetalles", new[] { "OrdenProduccionInsumoId" });
            AlterColumn("dbo.RecepcionDetalles", "CompraDetalleId", c => c.Int(nullable: false));
            AlterColumn("dbo.RecepcionDetalles", "OrdenProduccionInsumoId", c => c.Int(nullable: false));
            AlterColumn("dbo.DespachoDetalles", "VentaDetalleId", c => c.Int(nullable: false));
            AlterColumn("dbo.DespachoDetalles", "OrdenProduccionInsumoId", c => c.Int(nullable: false));
            CreateIndex("dbo.RecepcionDetalles", "CompraDetalleId");
            CreateIndex("dbo.RecepcionDetalles", "OrdenProduccionInsumoId");
            CreateIndex("dbo.DespachoDetalles", "VentaDetalleId");
            CreateIndex("dbo.DespachoDetalles", "OrdenProduccionInsumoId");
        }
    }
}
