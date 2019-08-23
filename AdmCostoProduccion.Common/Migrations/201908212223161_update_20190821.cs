namespace AdmCostoProduccion.Common.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_20190821 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CompraDetalles", "UnidadMedidaId", c => c.String(maxLength: 128));
            AddColumn("dbo.VentaDetalles", "UnidadMedidaId", c => c.String(maxLength: 128));
            CreateIndex("dbo.CompraDetalles", "UnidadMedidaId");
            CreateIndex("dbo.VentaDetalles", "UnidadMedidaId");
            AddForeignKey("dbo.CompraDetalles", "UnidadMedidaId", "dbo.UnidadMedidas", "UnidadMedidaId");
            AddForeignKey("dbo.VentaDetalles", "UnidadMedidaId", "dbo.UnidadMedidas", "UnidadMedidaId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VentaDetalles", "UnidadMedidaId", "dbo.UnidadMedidas");
            DropForeignKey("dbo.CompraDetalles", "UnidadMedidaId", "dbo.UnidadMedidas");
            DropIndex("dbo.VentaDetalles", new[] { "UnidadMedidaId" });
            DropIndex("dbo.CompraDetalles", new[] { "UnidadMedidaId" });
            DropColumn("dbo.VentaDetalles", "UnidadMedidaId");
            DropColumn("dbo.CompraDetalles", "UnidadMedidaId");
        }
    }
}
