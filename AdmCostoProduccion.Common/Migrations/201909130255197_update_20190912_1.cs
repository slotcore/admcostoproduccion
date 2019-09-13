namespace AdmCostoProduccion.Common.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_20190912_1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AjusteInventarioDetalles",
                c => new
                    {
                        AjusteInventarioDetalleId = c.String(nullable: false, maxLength: 128),
                        Cantidad = c.Double(nullable: false),
                        Costo = c.Double(nullable: false),
                        AjusteInventarioId = c.String(maxLength: 128),
                        MercaderiaId = c.String(maxLength: 128),
                        UnidadMedidaId = c.String(maxLength: 128),
                        UsuarioCreacion = c.String(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioUltimaActualizacion = c.String(),
                        FechaUltimaActualizacion = c.DateTime(),
                        Eliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.AjusteInventarioDetalleId)
                .ForeignKey("dbo.AjusteInventarios", t => t.AjusteInventarioId)
                .ForeignKey("dbo.Mercaderias", t => t.MercaderiaId)
                .ForeignKey("dbo.UnidadMedidas", t => t.UnidadMedidaId)
                .Index(t => t.AjusteInventarioId)
                .Index(t => t.MercaderiaId)
                .Index(t => t.UnidadMedidaId);
            
            CreateTable(
                "dbo.AjusteInventarios",
                c => new
                    {
                        AjusteInventarioId = c.String(nullable: false, maxLength: 128),
                        Codigo = c.String(),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                        Fecha = c.DateTime(nullable: false),
                        Observacion = c.String(),
                        TipoAjusteInventarioId = c.String(maxLength: 128),
                        AlmacenId = c.String(maxLength: 128),
                        UsuarioCreacion = c.String(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioUltimaActualizacion = c.String(),
                        FechaUltimaActualizacion = c.DateTime(),
                        Eliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.AjusteInventarioId)
                .ForeignKey("dbo.Almacens", t => t.AlmacenId)
                .ForeignKey("dbo.TipoAjusteInventarios", t => t.TipoAjusteInventarioId)
                .Index(t => t.TipoAjusteInventarioId)
                .Index(t => t.AlmacenId);
            
            CreateTable(
                "dbo.InventarioInicials",
                c => new
                    {
                        InventarioInicialId = c.String(nullable: false, maxLength: 128),
                        Codigo = c.String(),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                        Fecha = c.DateTime(nullable: false),
                        Observacion = c.String(),
                        AlmacenId = c.String(maxLength: 128),
                        UsuarioCreacion = c.String(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioUltimaActualizacion = c.String(),
                        FechaUltimaActualizacion = c.DateTime(),
                        Eliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.InventarioInicialId)
                .ForeignKey("dbo.Almacens", t => t.AlmacenId)
                .Index(t => t.AlmacenId);
            
            CreateTable(
                "dbo.InventarioInicialDetalles",
                c => new
                    {
                        InventarioInicialDetalleId = c.String(nullable: false, maxLength: 128),
                        Cantidad = c.Double(nullable: false),
                        Costo = c.Double(nullable: false),
                        InventarioInicialId = c.String(maxLength: 128),
                        MercaderiaId = c.String(maxLength: 128),
                        UnidadMedidaId = c.String(maxLength: 128),
                        UsuarioCreacion = c.String(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioUltimaActualizacion = c.String(),
                        FechaUltimaActualizacion = c.DateTime(),
                        Eliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.InventarioInicialDetalleId)
                .ForeignKey("dbo.InventarioInicials", t => t.InventarioInicialId)
                .ForeignKey("dbo.Mercaderias", t => t.MercaderiaId)
                .ForeignKey("dbo.UnidadMedidas", t => t.UnidadMedidaId)
                .Index(t => t.InventarioInicialId)
                .Index(t => t.MercaderiaId)
                .Index(t => t.UnidadMedidaId);
            
            CreateTable(
                "dbo.TipoAjusteInventarios",
                c => new
                    {
                        TipoAjusteInventarioId = c.String(nullable: false, maxLength: 128),
                        Codigo = c.String(),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                        UsuarioCreacion = c.String(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioUltimaActualizacion = c.String(),
                        FechaUltimaActualizacion = c.DateTime(),
                        Eliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.TipoAjusteInventarioId);
            
            AddColumn("dbo.DespachoDetalles", "AjusteInventarioDetalleId", c => c.String(maxLength: 128));
            AddColumn("dbo.Despachoes", "AjusteInventarioId", c => c.String(maxLength: 128));
            AddColumn("dbo.Recepcions", "InventarioInicialId", c => c.String(maxLength: 128));
            AddColumn("dbo.Recepcions", "AjusteInventarioId", c => c.String(maxLength: 128));
            AddColumn("dbo.RecepcionDetalles", "InventarioInicialDetalleId", c => c.String(maxLength: 128));
            AddColumn("dbo.RecepcionDetalles", "AjusteInventarioDetalleId", c => c.String(maxLength: 128));
            CreateIndex("dbo.DespachoDetalles", "AjusteInventarioDetalleId");
            CreateIndex("dbo.Despachoes", "AjusteInventarioId");
            CreateIndex("dbo.Recepcions", "InventarioInicialId");
            CreateIndex("dbo.Recepcions", "AjusteInventarioId");
            CreateIndex("dbo.RecepcionDetalles", "InventarioInicialDetalleId");
            CreateIndex("dbo.RecepcionDetalles", "AjusteInventarioDetalleId");
            AddForeignKey("dbo.DespachoDetalles", "AjusteInventarioDetalleId", "dbo.AjusteInventarioDetalles", "AjusteInventarioDetalleId");
            AddForeignKey("dbo.Despachoes", "AjusteInventarioId", "dbo.AjusteInventarios", "AjusteInventarioId");
            AddForeignKey("dbo.Recepcions", "AjusteInventarioId", "dbo.AjusteInventarios", "AjusteInventarioId");
            AddForeignKey("dbo.RecepcionDetalles", "AjusteInventarioDetalleId", "dbo.AjusteInventarioDetalles", "AjusteInventarioDetalleId");
            AddForeignKey("dbo.RecepcionDetalles", "InventarioInicialDetalleId", "dbo.InventarioInicialDetalles", "InventarioInicialDetalleId");
            AddForeignKey("dbo.Recepcions", "InventarioInicialId", "dbo.InventarioInicials", "InventarioInicialId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AjusteInventarios", "TipoAjusteInventarioId", "dbo.TipoAjusteInventarios");
            DropForeignKey("dbo.Recepcions", "InventarioInicialId", "dbo.InventarioInicials");
            DropForeignKey("dbo.InventarioInicialDetalles", "UnidadMedidaId", "dbo.UnidadMedidas");
            DropForeignKey("dbo.AjusteInventarioDetalles", "UnidadMedidaId", "dbo.UnidadMedidas");
            DropForeignKey("dbo.RecepcionDetalles", "InventarioInicialDetalleId", "dbo.InventarioInicialDetalles");
            DropForeignKey("dbo.RecepcionDetalles", "AjusteInventarioDetalleId", "dbo.AjusteInventarioDetalles");
            DropForeignKey("dbo.InventarioInicialDetalles", "MercaderiaId", "dbo.Mercaderias");
            DropForeignKey("dbo.InventarioInicialDetalles", "InventarioInicialId", "dbo.InventarioInicials");
            DropForeignKey("dbo.InventarioInicials", "AlmacenId", "dbo.Almacens");
            DropForeignKey("dbo.Recepcions", "AjusteInventarioId", "dbo.AjusteInventarios");
            DropForeignKey("dbo.AjusteInventarioDetalles", "MercaderiaId", "dbo.Mercaderias");
            DropForeignKey("dbo.Despachoes", "AjusteInventarioId", "dbo.AjusteInventarios");
            DropForeignKey("dbo.DespachoDetalles", "AjusteInventarioDetalleId", "dbo.AjusteInventarioDetalles");
            DropForeignKey("dbo.AjusteInventarios", "AlmacenId", "dbo.Almacens");
            DropForeignKey("dbo.AjusteInventarioDetalles", "AjusteInventarioId", "dbo.AjusteInventarios");
            DropIndex("dbo.RecepcionDetalles", new[] { "AjusteInventarioDetalleId" });
            DropIndex("dbo.RecepcionDetalles", new[] { "InventarioInicialDetalleId" });
            DropIndex("dbo.InventarioInicialDetalles", new[] { "UnidadMedidaId" });
            DropIndex("dbo.InventarioInicialDetalles", new[] { "MercaderiaId" });
            DropIndex("dbo.InventarioInicialDetalles", new[] { "InventarioInicialId" });
            DropIndex("dbo.InventarioInicials", new[] { "AlmacenId" });
            DropIndex("dbo.Recepcions", new[] { "AjusteInventarioId" });
            DropIndex("dbo.Recepcions", new[] { "InventarioInicialId" });
            DropIndex("dbo.Despachoes", new[] { "AjusteInventarioId" });
            DropIndex("dbo.DespachoDetalles", new[] { "AjusteInventarioDetalleId" });
            DropIndex("dbo.AjusteInventarios", new[] { "AlmacenId" });
            DropIndex("dbo.AjusteInventarios", new[] { "TipoAjusteInventarioId" });
            DropIndex("dbo.AjusteInventarioDetalles", new[] { "UnidadMedidaId" });
            DropIndex("dbo.AjusteInventarioDetalles", new[] { "MercaderiaId" });
            DropIndex("dbo.AjusteInventarioDetalles", new[] { "AjusteInventarioId" });
            DropColumn("dbo.RecepcionDetalles", "AjusteInventarioDetalleId");
            DropColumn("dbo.RecepcionDetalles", "InventarioInicialDetalleId");
            DropColumn("dbo.Recepcions", "AjusteInventarioId");
            DropColumn("dbo.Recepcions", "InventarioInicialId");
            DropColumn("dbo.Despachoes", "AjusteInventarioId");
            DropColumn("dbo.DespachoDetalles", "AjusteInventarioDetalleId");
            DropTable("dbo.TipoAjusteInventarios");
            DropTable("dbo.InventarioInicialDetalles");
            DropTable("dbo.InventarioInicials");
            DropTable("dbo.AjusteInventarios");
            DropTable("dbo.AjusteInventarioDetalles");
        }
    }
}
