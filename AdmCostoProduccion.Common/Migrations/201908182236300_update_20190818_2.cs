namespace AdmCostoProduccion.Common.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_20190818_2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AplicacionCorrelativoes",
                c => new
                    {
                        AplicacionCorrelativoId = c.String(nullable: false, maxLength: 128),
                        Codigo = c.String(),
                        Nombre = c.String(),
                        Prefijo = c.String(),
                        NumeroDigitos = c.Int(nullable: false),
                        Correlativo = c.Int(nullable: false),
                        UsuarioCreacion = c.String(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioUltimaActualizacion = c.String(),
                        FechaUltimaActualizacion = c.DateTime(),
                        Eliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.AplicacionCorrelativoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AplicacionCorrelativoes");
        }
    }
}
