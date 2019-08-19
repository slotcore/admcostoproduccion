namespace AdmCostoProduccion.Common.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_20190818 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AplicacionConfiguracions", "CompraGeneraMovimiento", c => c.Boolean(nullable: false));
            AddColumn("dbo.AplicacionConfiguracions", "VentaGeneraMovimiento", c => c.Boolean(nullable: false));
            DropColumn("dbo.AplicacionConfiguracions", "RecepcionGeneraMovimiento");
            DropColumn("dbo.AplicacionConfiguracions", "DespachoGeneraMovimiento");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AplicacionConfiguracions", "DespachoGeneraMovimiento", c => c.Boolean(nullable: false));
            AddColumn("dbo.AplicacionConfiguracions", "RecepcionGeneraMovimiento", c => c.Boolean(nullable: false));
            DropColumn("dbo.AplicacionConfiguracions", "VentaGeneraMovimiento");
            DropColumn("dbo.AplicacionConfiguracions", "CompraGeneraMovimiento");
        }
    }
}
