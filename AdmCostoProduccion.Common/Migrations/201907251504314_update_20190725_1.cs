namespace AdmCostoProduccion.Common.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_20190725_1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ventas",
                c => new
                    {
                        VentaId = c.Int(nullable: false, identity: true),
                        NumeroDocumento = c.String(),
                        Fecha = c.DateTime(nullable: false),
                        Descripcion = c.String(),
                        CentroLogisticoId = c.Int(nullable: false),
                        UsuarioCreacion = c.String(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioUltimaActualizacion = c.String(),
                        FechaUltimaActualizacion = c.DateTime(),
                        Eliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.VentaId)
                .ForeignKey("dbo.CentroLogisticoes", t => t.CentroLogisticoId)
                .Index(t => t.CentroLogisticoId);
            
            CreateTable(
                "dbo.VentaDetalles",
                c => new
                    {
                        VentaDetalleId = c.Int(nullable: false, identity: true),
                        Cantidad = c.Double(nullable: false),
                        PrecioUnitario = c.Double(nullable: false),
                        VentaId = c.Int(nullable: false),
                        MercaderiaId = c.Int(nullable: false),
                        UsuarioCreacion = c.String(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioUltimaActualizacion = c.String(),
                        FechaUltimaActualizacion = c.DateTime(),
                        Eliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.VentaDetalleId)
                .ForeignKey("dbo.Mercaderias", t => t.MercaderiaId)
                .ForeignKey("dbo.Ventas", t => t.VentaId)
                .Index(t => t.VentaId)
                .Index(t => t.MercaderiaId);
            
            CreateTable(
                "dbo.CompraDetalles",
                c => new
                    {
                        CompraDetalleId = c.Int(nullable: false, identity: true),
                        Cantidad = c.Double(nullable: false),
                        PrecioUnitario = c.Double(nullable: false),
                        PrecioTotal = c.Double(nullable: false),
                        CompraId = c.Int(nullable: false),
                        MercaderiaId = c.Int(nullable: false),
                        UsuarioCreacion = c.String(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioUltimaActualizacion = c.String(),
                        FechaUltimaActualizacion = c.DateTime(),
                        Eliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CompraDetalleId)
                .ForeignKey("dbo.Compras", t => t.CompraId)
                .ForeignKey("dbo.Mercaderias", t => t.MercaderiaId)
                .Index(t => t.CompraId)
                .Index(t => t.MercaderiaId);
            
            CreateTable(
                "dbo.Compras",
                c => new
                    {
                        CompraId = c.Int(nullable: false, identity: true),
                        NumeroDocumento = c.String(),
                        Fecha = c.DateTime(nullable: false),
                        Descripcion = c.String(),
                        CentroLogisticoId = c.Int(nullable: false),
                        UsuarioCreacion = c.String(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioUltimaActualizacion = c.String(),
                        FechaUltimaActualizacion = c.DateTime(),
                        Eliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CompraId)
                .ForeignKey("dbo.CentroLogisticoes", t => t.CentroLogisticoId)
                .Index(t => t.CentroLogisticoId);
            
            AddColumn("dbo.DespachoDetalles", "VentaDetalleId", c => c.Int(nullable: false));
            AddColumn("dbo.Despachoes", "VentaId", c => c.Int(nullable: false));
            AddColumn("dbo.RecepcionDetalles", "CompraDetalleId", c => c.Int(nullable: false));
            AddColumn("dbo.Recepcions", "CompraId", c => c.Int(nullable: false));
            CreateIndex("dbo.DespachoDetalles", "VentaDetalleId");
            CreateIndex("dbo.Despachoes", "VentaId");
            CreateIndex("dbo.Recepcions", "CompraId");
            CreateIndex("dbo.RecepcionDetalles", "CompraDetalleId");
            AddForeignKey("dbo.Despachoes", "VentaId", "dbo.Ventas", "VentaId");
            AddForeignKey("dbo.DespachoDetalles", "VentaDetalleId", "dbo.VentaDetalles", "VentaDetalleId");
            AddForeignKey("dbo.Recepcions", "CompraId", "dbo.Compras", "CompraId");
            AddForeignKey("dbo.RecepcionDetalles", "CompraDetalleId", "dbo.CompraDetalles", "CompraDetalleId");
            DropColumn("dbo.OrdenProduccions", "Nombre");
        }
        
        public override void Down()
        {
            AddColumn("dbo.OrdenProduccions", "Nombre", c => c.String());
            DropForeignKey("dbo.VentaDetalles", "VentaId", "dbo.Ventas");
            DropForeignKey("dbo.VentaDetalles", "MercaderiaId", "dbo.Mercaderias");
            DropForeignKey("dbo.CompraDetalles", "MercaderiaId", "dbo.Mercaderias");
            DropForeignKey("dbo.RecepcionDetalles", "CompraDetalleId", "dbo.CompraDetalles");
            DropForeignKey("dbo.Recepcions", "CompraId", "dbo.Compras");
            DropForeignKey("dbo.CompraDetalles", "CompraId", "dbo.Compras");
            DropForeignKey("dbo.Compras", "CentroLogisticoId", "dbo.CentroLogisticoes");
            DropForeignKey("dbo.DespachoDetalles", "VentaDetalleId", "dbo.VentaDetalles");
            DropForeignKey("dbo.Despachoes", "VentaId", "dbo.Ventas");
            DropForeignKey("dbo.Ventas", "CentroLogisticoId", "dbo.CentroLogisticoes");
            DropIndex("dbo.RecepcionDetalles", new[] { "CompraDetalleId" });
            DropIndex("dbo.Recepcions", new[] { "CompraId" });
            DropIndex("dbo.Compras", new[] { "CentroLogisticoId" });
            DropIndex("dbo.CompraDetalles", new[] { "MercaderiaId" });
            DropIndex("dbo.CompraDetalles", new[] { "CompraId" });
            DropIndex("dbo.VentaDetalles", new[] { "MercaderiaId" });
            DropIndex("dbo.VentaDetalles", new[] { "VentaId" });
            DropIndex("dbo.Ventas", new[] { "CentroLogisticoId" });
            DropIndex("dbo.Despachoes", new[] { "VentaId" });
            DropIndex("dbo.DespachoDetalles", new[] { "VentaDetalleId" });
            DropColumn("dbo.Recepcions", "CompraId");
            DropColumn("dbo.RecepcionDetalles", "CompraDetalleId");
            DropColumn("dbo.Despachoes", "VentaId");
            DropColumn("dbo.DespachoDetalles", "VentaDetalleId");
            DropTable("dbo.Compras");
            DropTable("dbo.CompraDetalles");
            DropTable("dbo.VentaDetalles");
            DropTable("dbo.Ventas");
        }
    }
}
