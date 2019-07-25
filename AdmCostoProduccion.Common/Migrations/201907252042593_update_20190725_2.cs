namespace AdmCostoProduccion.Common.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_20190725_2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TipoDespachoes", "Proceso", c => c.String());
            AddColumn("dbo.TipoRecepcions", "Proceso", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TipoRecepcions", "Proceso");
            DropColumn("dbo.TipoDespachoes", "Proceso");
        }
    }
}
