namespace AdmCostoProduccion.Common.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_20190725_3 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Despachoes", new[] { "OrdenProduccionId" });
            DropIndex("dbo.Despachoes", new[] { "VentaId" });
            DropIndex("dbo.Recepcions", new[] { "OrdenProduccionId" });
            DropIndex("dbo.Recepcions", new[] { "CompraId" });
            AlterColumn("dbo.Despachoes", "OrdenProduccionId", c => c.Int());
            AlterColumn("dbo.Despachoes", "VentaId", c => c.Int());
            AlterColumn("dbo.Recepcions", "OrdenProduccionId", c => c.Int());
            AlterColumn("dbo.Recepcions", "CompraId", c => c.Int());
            CreateIndex("dbo.Despachoes", "OrdenProduccionId");
            CreateIndex("dbo.Despachoes", "VentaId");
            CreateIndex("dbo.Recepcions", "OrdenProduccionId");
            CreateIndex("dbo.Recepcions", "CompraId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Recepcions", new[] { "CompraId" });
            DropIndex("dbo.Recepcions", new[] { "OrdenProduccionId" });
            DropIndex("dbo.Despachoes", new[] { "VentaId" });
            DropIndex("dbo.Despachoes", new[] { "OrdenProduccionId" });
            AlterColumn("dbo.Recepcions", "CompraId", c => c.Int(nullable: false));
            AlterColumn("dbo.Recepcions", "OrdenProduccionId", c => c.Int(nullable: false));
            AlterColumn("dbo.Despachoes", "VentaId", c => c.Int(nullable: false));
            AlterColumn("dbo.Despachoes", "OrdenProduccionId", c => c.Int(nullable: false));
            CreateIndex("dbo.Recepcions", "CompraId");
            CreateIndex("dbo.Recepcions", "OrdenProduccionId");
            CreateIndex("dbo.Despachoes", "VentaId");
            CreateIndex("dbo.Despachoes", "OrdenProduccionId");
        }
    }
}
