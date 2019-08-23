namespace AdmCostoProduccion.Common.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_20190822_1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FamiliaMercaderias",
                c => new
                    {
                        FamiliaMercaderiaId = c.String(nullable: false, maxLength: 128),
                        Codigo = c.String(),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                        UsuarioCreacion = c.String(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioUltimaActualizacion = c.String(),
                        FechaUltimaActualizacion = c.DateTime(),
                        Eliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.FamiliaMercaderiaId);
            
            CreateTable(
                "dbo.ReglaAlmacenajes",
                c => new
                    {
                        ReglaAlmacenajeId = c.String(nullable: false, maxLength: 128),
                        Codigo = c.String(),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                        AlmacenId = c.String(maxLength: 128),
                        FamiliaMercaderiaId = c.String(maxLength: 128),
                        UsuarioCreacion = c.String(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioUltimaActualizacion = c.String(),
                        FechaUltimaActualizacion = c.DateTime(),
                        Eliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ReglaAlmacenajeId)
                .ForeignKey("dbo.Almacens", t => t.AlmacenId)
                .ForeignKey("dbo.FamiliaMercaderias", t => t.FamiliaMercaderiaId)
                .Index(t => t.AlmacenId)
                .Index(t => t.FamiliaMercaderiaId);
            
            AddColumn("dbo.Mercaderias", "FamiliaMercaderiaId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Mercaderias", "FamiliaMercaderiaId");
            AddForeignKey("dbo.Mercaderias", "FamiliaMercaderiaId", "dbo.FamiliaMercaderias", "FamiliaMercaderiaId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ReglaAlmacenajes", "FamiliaMercaderiaId", "dbo.FamiliaMercaderias");
            DropForeignKey("dbo.ReglaAlmacenajes", "AlmacenId", "dbo.Almacens");
            DropForeignKey("dbo.Mercaderias", "FamiliaMercaderiaId", "dbo.FamiliaMercaderias");
            DropIndex("dbo.ReglaAlmacenajes", new[] { "FamiliaMercaderiaId" });
            DropIndex("dbo.ReglaAlmacenajes", new[] { "AlmacenId" });
            DropIndex("dbo.Mercaderias", new[] { "FamiliaMercaderiaId" });
            DropColumn("dbo.Mercaderias", "FamiliaMercaderiaId");
            DropTable("dbo.ReglaAlmacenajes");
            DropTable("dbo.FamiliaMercaderias");
        }
    }
}
